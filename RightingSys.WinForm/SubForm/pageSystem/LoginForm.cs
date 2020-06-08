using System;
using System.Data;
using System.Windows.Forms;
using RightingSys.WinForm.Utility.cls;

namespace RightingSys.WinForm.SubForm.pageSystem
{
    public partial class LoginForm : DevExpress.XtraEditors.XtraForm
    {
        private RightingSys.BLL.RightingSysManager _appRight;

        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        /// <param name="appRight">权限业务类</param>
        public LoginForm(RightingSys.BLL.RightingSysManager appRight)
        {
            InitializeComponent();
            _appRight = appRight;
        }

        /// <summary>
        /// 设置焦点
        /// </summary>
        public void SetFocus()
        {
            if (this.txtLoginName.Text == "")
            {
                this.txtLoginName.Focus();
                return;
            }
            this.txtLoginPwd.Focus();
        }

        /// <summary>
        /// 取消登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 登录方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (doLogin())
            {
                clsPublic.SaveLoginConfig();
                clsPublicLogs.AddNewLoginLog();
                base.DialogResult = DialogResult.OK;
            }
        }

        /// <summary>
        /// 登录方法
        /// </summary>
        /// <returns></returns>
        private bool doLogin()
        {
            string text = this.txtLoginName.Text.Trim();
            string text2 = this.txtLoginPwd.Text.Trim();
            try
            {
                DataTable dataTable = _appRight.GetUserInfo(text, text2);
                if (dataTable == null || dataTable.Rows.Count < 1)
                {
                    clsPublic.ShowMessage("用户和密码错误", this.Text);
                    return false;
                }

                DataRow dataRow = dataTable.Rows[0];
                clsSession._UserId = clsPublic.GetObjGUID(dataRow["Id"]);
                clsSession._LoginName = clsPublic.GetObjectString(dataRow["LoginName"]);
                clsSession._FullName = clsPublic.GetObjectString(dataRow["FullName"]);
                //clsSession._RoleID = clsPublic.GetObjGUID(dataRow["RoleID"]);
                //clsSession._RoleName= clsPublic.GetObjectString(dataRow["RoleName"]);
                clsSession._DepartmentId = clsPublic.GetObjGUID(dataRow["DepartmentId"]);
                clsSession._DepartmentName = clsPublic.GetObjectString(dataRow["DepartmentName"]);


                //if (_appRight.BlackIPIsLogin(clsSession._UserID))
                //{
                //    appLogs.LogOpInfo("用户登录", DateTime.Now);
                //    .UpdateLastLoginInf();
                //    return true;
                //}
                //else {
                //    clsPublic.ShowMessage("规则拒绝该用户[" + clsSession._LoginName + "]登录！", this.Text);
                //    appLogs.LogOpInfo("规则拒绝该用户登录", DateTime.Now);
                //    return false ;
                //}

                return true;
            }
            catch (Exception ex)
            {
                //appLogs.LogError("登录出错", ex);
                clsPublic.ShowMessage("系统出错", this.Text);
                return false;
            }
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FLogin_Load(object sender, EventArgs e)
        {
            clsPublic.ReadLoginConfig();//读取用户信息
            txtLoginName.Text = clsSession._LoginName;
            CheckRemPwd.Checked = clsSession._IsRemPwd;
            txtLoginPwd.Text = clsSession._IsRemPwd? clsSession._LoginPwd:"";
        }
    }
}


