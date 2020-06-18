namespace RightingSys.WinForm.SubForm.pageHelper
{
    public partial class AboutForm : BaseForm
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 获取显示系统版信息
        /// </summary>
        public void ShowSystemVersion()
        {
            BLL.SystemManager systemMg = new BLL.SystemManager();
            Models.ACL_System  model = systemMg.GetOneById(Models.SqlHelper.Session._SystemId);

            labSystemName.Text ="系统："+ model.SystemName;
            labSystemVersion.Text ="系统版本："+ model.Version;
            labListTime.Text = "更新时间："+model.LastTime.ToString();
        }


        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AboutForm_Load(object sender, System.EventArgs e)
        {
            ShowSystemVersion();
        }
    }
}
