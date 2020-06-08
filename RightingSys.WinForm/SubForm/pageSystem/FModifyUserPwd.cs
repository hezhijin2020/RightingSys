using RightingSys.WinForm.Utility.cls;
using System;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageSystem
{
    public partial class FModifyUserPwd : BaseForm
    {
        RightingSys.BLL.RightingSysManager _appRight;
        public FModifyUserPwd(RightingSys.BLL.RightingSysManager appRight)
        {
            InitializeComponent();
            _appRight = appRight;
        }

        private void sbtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sbtnSave_Click(object sender, EventArgs e)
        {
            Guid userid = clsSession._UserId;
            string oldpwd = txtOldPwd.Text.Trim();
            string newpwd = txtNewPwd1.Text.Trim();
            if (oldpwd == "")
            {
                MessageBox.Show("原密码不能为空", Text);
                txtOldPwd.Focus();
            }
            else
            {
                if (oldpwd == newpwd)
                {
                    MessageBox.Show("两次输入的密码不一致，请重新输入！", Text);
                    txtNewPwd1.Focus();
                }
                else
                {

                    if (_appRight.ModifyUserPwd(userid, oldpwd, newpwd))
                    {
                        MessageBox.Show("密码修改成功！", Text);
                      //  clsPublic.appLogs.LogOpInfo("修改密码",DateTime.Now);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("原密码错识修改失败！", Text);
                        txtOldPwd.Focus();
                    }
                }
            }
        }
    }
}
