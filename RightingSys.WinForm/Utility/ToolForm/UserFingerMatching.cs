using libzkfpcsharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using RightingSys.WinForm.Utility.cls;

namespace RightingSys.WinForm.Utility.ToolForm
{
    public partial class UserFingerMatching : DevExpress.XtraEditors.XtraForm
    {

        
        List<Models.ACL_FingerPrint> AllFinger = new List<Models.ACL_FingerPrint>();
        RightingSys.BLL.FingerPrintManager fingerMg = new RightingSys.BLL.FingerPrintManager();
        Models.ACL_FingerPrint model = new Models.ACL_FingerPrint();

        public UserFingerMatching()
        {
            InitializeComponent();
            AllFinger = fingerMg.GetAllList();
            lbeFingerCount.Text = string.Format("当前系统指纹模板数：{0}", AllFinger.Count);
            if (AllFinger.Count > 0)
            {
                bnInit_Click(null, null);
                bnOpen_Click(null, null);
            }
        }

        public UserFingerMatching(Guid _USERID)
        {
            InitializeComponent();
            AllFinger = fingerMg.GetAllList().Where(s=>s.UserId==_USERID).ToList();
            lbeFingerCount.Text = string.Format("当前用户[{1}]指纹模板数：{0}",AllFinger.Count,AllFinger[0].FullName);
            if (AllFinger.Count > 0)
            {
                bnInit_Click(null, null);
                bnOpen_Click(null, null);
            }
        }

       

        IntPtr mDevHandle = IntPtr.Zero;
        IntPtr mDBHandle = IntPtr.Zero;
        IntPtr FormHandle = IntPtr.Zero;
        bool bIsTimeToDie = false;
        byte[] FPBuffer;
        byte[] CapTmp = new byte[2048];
        int cbCapTmp = 2048;
        private int mfpWidth = 0;
        private int mfpHeight = 0;

        const int MESSAGE_CAPTURED_OK = 0x0400 + 6;

        [DllImport("user32.dll", EntryPoint = "SendMessageA")]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);
        
        private void bnInit_Click(object sender, EventArgs e)
        {
            int ret = zkfperrdef.ZKFP_ERR_OK;
            if ((ret = zkfp2.Init()) == zkfperrdef.ZKFP_ERR_OK)//初始化设备，并获取返回值，指示是否成功！
            {
                int nCount = zkfp2.GetDeviceCount();
                if (nCount<= 0)
                {
                    zkfp2.Terminate();//释放资源
                    clsPublic.ShowMessage("没有连接设备！");
                }
            }
            else
            {
                clsPublic.ShowMessage("初始化失败" + ret + " !");
            }
        }
        private void bnOpen_Click(object sender, EventArgs e)
        {
            int ret = zkfp.ZKFP_ERR_OK;
            if (IntPtr.Zero == (mDevHandle = zkfp2.OpenDevice(0)))//打开设备，并获取返回值，指示是否成功！
            {
                clsPublic.ShowMessage("打开设备失败");
                return;
            }
            if (IntPtr.Zero == (mDBHandle = zkfp2.DBInit()))//初始化算法库，并获取返回值，指示是否成功！
            {
                clsPublic.ShowMessage("初始化数据库失败");
                zkfp2.CloseDevice(mDevHandle);// 关闭设备
                mDevHandle = IntPtr.Zero;
                return;
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
            textRes.Text = "\r\n指纹采集器启动成功"+textRes.Text;

        }


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
                        foreach (Models.ACL_FingerPrint PF in AllFinger)
                        {
                            int ret = zkfp2.DBMatch(mDBHandle, CapTmp, PF.FingerData);
                            if (50< ret)
                            {
                                textRes.Text =string.Format( "\r\n匹配率={0} 姓名:{1} 指纹ID:{2} ",ret,PF.FullName,PF.Id) + textRes.Text ;
                                return;
                            }
                        }
                        textRes.Text = "\r\n没有找到匹配到用户指纹信息" + textRes.Text;
                    }
                    break;

                default:
                    base.DefWndProc(ref m);
                    break;
            }
        }
        
        private void bnClose_Click(object sender, EventArgs e)
        {
            bIsTimeToDie = true;
            Thread.Sleep(1000);
            zkfp2.CloseDevice(mDevHandle);
            zkfp2.Terminate();//释放资源
        }

        private void UserFingerMatching_Load(object sender, EventArgs e)
        {
            FormHandle = this.Handle;
        }

        private void UserFingerMatching_FormClosing(object sender, FormClosingEventArgs e)
        {
            bnClose_Click(null, null);
        }
    }
}
