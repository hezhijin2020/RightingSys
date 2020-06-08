using libzkfpcsharp;
using RightingSys.WinForm.Utility.cls;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace RightingSys.WinForm.Utility.ToolForm
{
    public partial class UserFingerAdd : DevExpress.XtraEditors.XtraForm
    {
        private Guid _UserId;
        RightingSys.BLL.FingerPrintManager fingerMg = new RightingSys.BLL.FingerPrintManager();
        Models.ACL_FingerPrint model = new Models.ACL_FingerPrint();
        public UserFingerAdd(Guid _USERID,string FullName,string DepartmentName)
        {
            InitializeComponent();
            model.UserId = _UserId=_USERID;
            txtFullName.Text=txtLoginName.Text=FullName;
            txtDeptName.Text=DepartmentName;
        }


        private void UserFingerAdd_Load(object sender, EventArgs e)
        {
            FormHandle = this.Handle;

        }

        private void UserFingerAdd_FormClosing(object sender, FormClosingEventArgs e)
        {
            bIsTimeToDie = true;
            RegisterCount = 0;
            Thread.Sleep(1000);
            zkfp2.CloseDevice(mDevHandle);
            zkfp2.Terminate();//释放资源
        }

        #region   指纹登记

        IntPtr mDevHandle = IntPtr.Zero;
        IntPtr mDBHandle = IntPtr.Zero;
        IntPtr FormHandle = IntPtr.Zero;
        bool bIsTimeToDie = false;
        bool IsRegister = false;
        byte[] FPBuffer;
        int RegisterCount = 0;
        const int REGISTER_FINGER_COUNT = 3;

        byte[][] RegTmps = new byte[3][];
        byte[] RegTmp = new byte[2048];
        byte[] CapTmp = new byte[2048];
        int cbCapTmp = 2048;
        int cbRegTmp = 0;

        private int mfpWidth = 0;
        private int mfpHeight = 0;
        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);

        /// <summary>
        /// 初始化设备
        /// </summary>

        private void bnInit_Click(object sender, EventArgs e)
        {
            int ret = zkfperrdef.ZKFP_ERR_OK;
            if ((ret = zkfp2.Init()) == zkfperrdef.ZKFP_ERR_OK)//初始化设备，并获取返回值，指示是否成功！
            {
                int nCount = zkfp2.GetDeviceCount();
                if (nCount<=0)
                {
                    zkfp2.Terminate();//释放资源
                    MessageBox.Show("没有连接设备！");
                }
            }
            else
            {
                MessageBox.Show("初始化失败" + ret + " !");
            }
        }

        /// <summary>
        /// 打开设备
        /// </summary>
        private void bnOpen_Click(object sender, EventArgs e)
        {
            int ret = zkfp.ZKFP_ERR_OK;
            if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(0)))//打开设备，并获取返回值，指示是否成功！
            {
                MessageBox.Show("打开设备失败");
                return;
            }
            if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))//初始化算法库，并获取返回值，指示是否成功！
            {
                MessageBox.Show("初始化数据库失败");
                zkfp2.CloseDevice(mDevHandle);// 关闭设备
                mDevHandle = IntPtr.Zero;
                return;
            }
            RegisterCount = 0;
            cbRegTmp = 0;
            for (int i = 0; i < 3; i++)
            {
                RegTmps[i] = new byte[2048];
            }
            byte[] paramValue = new byte[4];
            int size = 4;
            zkfp2.GetParameters(mDevHandle, 1, paramValue, ref size);
            zkfp2.ByteArray2Int(paramValue, ref mfpWidth);

            size = 4;
            zkfp2.GetParameters(mDevHandle, 2, paramValue, ref size);
            zkfp2.ByteArray2Int(paramValue, ref mfpHeight);

            FPBuffer = new byte[mfpWidth * mfpHeight];

            Thread captureThread = new Thread(new ThreadStart(DoCapture));
            captureThread.IsBackground = true;
            captureThread.Start();
            bIsTimeToDie = false;
            textRes.Text =  "指纹采集器启动成功\r\n"+textRes.Text;

        }


        /// <summary>
        /// 捕获指纹信息方法
        /// </summary>
        private void DoCapture()
        {
            while (!bIsTimeToDie)
            {
                cbCapTmp = 2048;
                int ret = zkfp2.AcquireFingerprint(mDevHandle, FPBuffer, CapTmp, ref cbCapTmp);
                if (ret == zkfp.ZKFP_ERR_OK)
                {
                    SendMessage(FormHandle, MESSAGE_CAPTURED_OK, IntPtr.Zero, IntPtr.Zero);
                }
                Thread.Sleep(200);
            }
        }
        
        /// <summary>
        /// 启用指纹登记
        /// </summary>
        private void bnEnroll_Click(object sender, EventArgs e)
        {
            if (!IsRegister)
            {
                bnInit_Click(null, null);
                bnOpen_Click(null, null);

                IsRegister = true;
                RegisterCount = 0;
                textRes.Text = "请按手指三次！\r\n"+textRes.Text;
                bnEnroll.Enabled = false;
            }
        }

       /// <summary>
       /// windows 信息处理机制
       /// </summary>
        protected override void DefWndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case MESSAGE_CAPTURED_OK:
                    {
                        MemoryStream ms = new MemoryStream();
                        BitmapFormat.GetBitmap(FPBuffer, mfpWidth, mfpHeight, ref ms);
                        Bitmap bmp = new Bitmap(ms);
                        this.picFPImg.Image = bmp;
                        if (IsRegister)
                        {
                            int ret = zkfp.ZKFP_ERR_OK;
                            if (RegisterCount > 0 && zkfp2.DBMatch(mDBHandle, CapTmp, RegTmps[RegisterCount - 1]) <= 0)
                            {
                                textRes.Text = "请按同一个手指3次报名+\r\n"+textRes.Text;
                                return;
                            }
                            Array.Copy(CapTmp, RegTmps[RegisterCount], cbCapTmp);
                            RegisterCount++;
                            if (RegisterCount >= REGISTER_FINGER_COUNT)
                            {
                                RegisterCount = 0;
                                if (zkfp.ZKFP_ERR_OK == (ret = zkfp2.DBMerge(mDBHandle, RegTmps[0], RegTmps[1], RegTmps[2], RegTmp, ref cbRegTmp)))
                                {
                                    model.Id = Guid.NewGuid();
                                    model.FingerData = RegTmp;
                                    model.FingerDescription = cbmFingerRemark.SelectedItem.ToString();
                                    model.CreateTime = DateTime.Now;
                                    if (fingerMg.AddNew(model))
                                    {
                                        textRes.Text = "\r\n登记成功\r\n" + textRes.Text ;
                                        Utility.cls.clsPublic.ShowMessage("登记成功","Finger提示");
                                    }
                                    else
                                    {
                                        textRes.Text = "登记失败请重新登记\r\n" + textRes.Text ;
                                    }
                                   
                                    bnEnroll.Enabled = true;
                                    UserFingerAdd_FormClosing(null, null);
                                }
                                else
                                {
                                    textRes.Text ="注册失败, 错误代码=" + ret+"\r\n" +textRes.Text;
                                    bnEnroll.Enabled = true;
                                    UserFingerAdd_FormClosing(null, null);
                                }
                                IsRegister = false;
                                return;
                            }
                            else
                            {
                                textRes.Text = "你需要按下 " + (REGISTER_FINGER_COUNT - RegisterCount) + " 次指纹\r\n"+ textRes.Text ;
                            }
                        }
                    }
                    break;
                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }
        #endregion

    
    }
}
