using RightingSys.WinForm.Utility.cls;
using System;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageSystem
{
    public partial class FModifyUserPwd : BaseForm
    {
        RightingSys.BLL.RightingSysManager _appRight;

        /// <summary>
        /// 带参数的构造函数
        /// </summary>
        /// <param name="appRight"></param>
        public FModifyUserPwd(RightingSys.BLL.RightingSysManager appRight)
        {
            InitializeComponent();
            _appRight = appRight;
        }

        /// <summary>
        /// 取消修改密码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 修改密码确定事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            Guid userid = Models.SqlHelper.Session._UserId;
            string oldpwd = txtOldPwd.Text.Trim();
            string newpwd = txtNewPwd1.Text.Trim();
            if (oldpwd == "")
            {
                clsPublic.ShowMessage("原密码不能为空", Text);
                txtOldPwd.Focus();
            }
            else
            {
                if (oldpwd == newpwd)
                {
                    clsPublic.ShowMessage("两次输入的密码不一致，请重新输入！", Text);
                    txtNewPwd1.Focus();
                }
                else
                {

                    if (_appRight.ModifyUserPwd(userid, oldpwd, newpwd))
                    {
                        clsPublic.ShowMessage("密码修改成功！", Text);
                      //  clsPublic.appLogs.LogOpInfo("修改密码",DateTime.Now);
                        this.Close();
                    }
                    else
                    {
                        clsPublic.ShowMessage("原密码错识修改失败！", Text);
                        txtOldPwd.Focus();
                    }
                }
            }
        }
    }
}
