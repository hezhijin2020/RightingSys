using DevExpress.Skins;
using DevExpress.UserSkins;
using RightingSys.WinForm.AppPublic.AutoService;
using RightingSys.WinForm.Utility.cls;
using System;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;

namespace RightingSys.WinForm
{
    static class Program
    {
     

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                BindExceptionHandler();//异常处理
                BonusSkins.Register();//系统主题
                SkinManager.EnableFormSkins();

                Application.EnableVisualStyles();//程序设置及启动
                Application.SetCompatibleTextRenderingDefault(false);
                Program.AppMutex= new Mutex(true, "RightingSys", out Program.IsRun);

                if (Program.IsNeedUpdate())
                {
                    StartUpdate();
                }
                else
                {
                    if (IsRun)
                    {
                        AppMutex.ReleaseMutex();
                        Application.Run(new MainForm());
                    }
                    else
                    {
                        MessageBox.Show("已经有一个实例正在运行!", "提示");
                    }
                }
            }
            catch(Exception ex) {
                MessageBox.Show(ex.GetType().Name.ToString());
            }
        }

        #region 程序更新

        static Mutex AppMutex;
        static bool IsRun = false;
        static RightingSys.BLL.SystemManager systemMg = new RightingSys.BLL.SystemManager();
        private static void StartUpdate()
        {
            try
            {
                Process.Start(Application.StartupPath + "\\AutoUpdate.exe");
                Process[] processesByName = Process.GetProcessesByName("RightingSys.exe");
                Process[] array = processesByName;
                for (int i = 0; i < array.Length; i++)
                {
                    Process process = array[i];
                    process.Kill();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("程序异常信息："+ex.Message,"提示");
                throw;
            }
        }

        public static bool IsNeedUpdate()
        {
            bool result = false; 
            try
            {
                string FileName = Application.StartupPath + "\\UpdateList.xml";
                XmlFiles xdoc = new XmlFiles(FileName);
                string version = xdoc.GetNodeValue("AutoUpdate/Application/Version");
                result = systemMg.IsNeedUpdate(clsSession._SystemId, version);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                result = false;
            }
            return result;
        }
          



        #endregion

        #region   在Winform程序中捕获全局异常
        //Application.ThreadException 事件--当UI线程中某个异常未被捕获时出现。
        //AppDomain.UnhandledException 事件--当非UI线程中某个异常未被捕获时出现。
        /// <summary>
        /// 绑定程序中的异常处理
        /// </summary>
        private static void BindExceptionHandler()
        {
            //设置应用程序处理异常方式：ThreadException处理
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
            //处理UI线程异常
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);
            //处理未捕获的异常
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
        }
        /// <summary>
        /// 处理UI线程异常
        /// </summary>
        static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
           // clsPublic.appLogs.LogError(null, e.Exception as Exception);
        }
        /// <summary>
        /// 处理未捕获的异常
        /// </summary>
        static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
           // clsPublic.appLogs.LogError(null, e.ExceptionObject as Exception);
        }
        #endregion
    }
}
