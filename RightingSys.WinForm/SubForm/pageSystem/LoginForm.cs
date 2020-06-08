using System;
using System.Collections.Generic;
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

                DataRow dataRow = dataTable.Rows[0];
                Models.SqlHelper.Session._UserId = clsPublic.GetObjGUID(dataRow["Id"]);
                Models.SqlHelper.Session._LoginName = clsPublic.GetObjectString(dataRow["LoginName"]);
                Models.SqlHelper.Session._FullName = clsPublic.GetObjectString(dataRow["FullName"]);
                Models.SqlHelper.Session._DepartmentId = clsPublic.GetObjGUID(dataRow["DepartmentId"]);
                Models.SqlHelper.Session._DepartmentName = clsPublic.GetObjectString(dataRow["DepartmentName"]);

                return true;
            }
            catch (Exception ex)
            {
                clsPublic.ShowMessage("系统出错,错误信息："+ex.Message, this.Text);
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

            //设置读取的用户信息
            txtLoginName.Text = Models.SqlHelper.Session._LoginName;
            CheckRemPwd.Checked = Models.SqlHelper.Session._IsRemPwd;
            txtLoginPwd.Text = Models.SqlHelper.Session._IsRemPwd? Models.SqlHelper.Session._LoginPwd:"";
        }
    }
}


