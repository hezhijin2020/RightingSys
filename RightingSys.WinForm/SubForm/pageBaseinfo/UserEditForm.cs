using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    public partial class UserEditForm : BaseForm
    {
        RightingSys.BLL.UserManager userMg = new RightingSys.BLL.UserManager();
        RightingSys.BLL.DepartmentManager deptMg = new RightingSys.BLL.DepartmentManager();
        Models.ACL_User model = null;
       
        public UserEditForm()
        {
            InitializeComponent();
            AddInitial();
        }


        #region 新增初始化
        private void AddInitial()
        {
            model = new Models.ACL_User();
            tlDepartment.Properties.DataSource = deptMg.GetAllList();
        }

        private void EditInitial(Guid UserId)
        {
            AddInitial();
            model = userMg.GetOneById(UserId);
            sbtnAdd.Visible = false;
            if (model != null)
            {
                txtLoginName.Text = model.LoginName;
                txtFullName.Text = model.FullName;
                tlDepartment.EditValue = model.DepartmentId;
                txtHandNo.Text = model.SimpleCode;
            }

        }

        #endregion

        public UserEditForm(Guid guidID)
        {
            InitializeComponent();
            EditInitial(guidID);
        }
        

        private void stbnSave_Click(object sender, EventArgs e)
        {
            if (ValidInputDate())
            {
                if (model.Id == Guid.Empty)
                {
                    model.Id = Guid.NewGuid();
                    if (userMg.AddNew(model))
                    {
                        MessageBox.Show("保存成功！");
                        base.DialogResult = DialogResult.OK;
                    }
                }
                else {
                    if (userMg.Modify(model))
                    {
                        MessageBox.Show("修改成功！");
                        base.DialogResult = DialogResult.OK;
                    }
                }
            }

        }

        private void sbtnCancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        #region 用户输入合法性检查、
        private bool ValidInputDate()
        {
            if (txtLoginName.Text.Trim() == "" || txtFullName.Text.Trim() == null || tlDepartment.EditValue == null)
            {
                MessageBox.Show("用户信息不能为空，请返回检查！");
                txtLoginName.Focus();
                return false;
            }
            else
            {
                if (model.Id == Guid.Empty || model == null)
                {
                    if (userMg.ExistsByName(txtLoginName.Text.Trim()))
                    {
                        MessageBox.Show("用户信息不能为空，请返回检查！");
                        txtLoginName.Focus();
                        return false;
                    }
                }
            }
            
            model.LoginName = txtLoginName.Text.Trim();
            model.SimpleCode = txtHandNo.Text;
            model.FullName = txtFullName.Text.Trim();
            model.DepartmentId = Guid.Parse(tlDepartment.EditValue.ToString());
            return true;
        }
        #endregion

       
    }
}
