using RightingSys.WinForm.Utility.cls;
using RightingSys.WinForm.Utility.ToolForm;
using System;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    public partial class FBlackIP_User : BaseForm
    {
        /// <summary>
        /// 声明变里
        /// </summary>
        Models.ACL_BlackIP model = new Models.ACL_BlackIP();
        BLL.BlackIPManager  manager = new BLL.BlackIPManager();

        /// <summary>
        /// 新增的构造函数
        /// </summary>
        public FBlackIP_User()
        {
            InitializeComponent();
            this.Text = "新增--" + this.Text;
            this.panelControl2.Enabled = false;
        }

        /// <summary>
        /// 带参数数的构造函数
        /// </summary>
        /// <param name="md">实体</param>
        public FBlackIP_User(Models.ACL_BlackIP md)
        {
            InitializeComponent();

            model = md;
            this.Text = "编辑--" + this.Text;
            if (model != null)
            {
                txtName.Text = model.BlackIPName;
                cboxType.SelectedItem = model.AuthorizeType!=true ? "黑名单" : "白名单";
                txtStartIP.Text = model.StartIP;
                txtEndIP.Text = model.EndIP;
                txtRemark.Text = model.Description;
                IsEnabled.Checked = model.IsRemoved ? false : true;
                gcUser.DataSource = manager.GetUserByBlackIP(model.Id);
            }
            else {
                clsPublic.ShowMessage("[规则]="+model.BlackIPName+"的记录不存在",Text);
                base.DialogResult = DialogResult.Cancel;
            }

        }

       /// <summary>
       /// 查询
       /// </summary>
        public override void Query()
        {
            gcUser.DataSource = manager.GetUserByBlackIP(model.Id);
        }

        /// <summary>
        /// 取消方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnClose_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 保存方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || txtStartIP.Text.Trim() == "" || txtEndIP.Text.Trim() == "")
            {
                clsPublic.ShowMessage("信息输入不完整", Text );
                return;
            }
            if (!clsPublic.IsCheckIP(txtStartIP.Text) || !clsPublic.IsCheckIP(txtEndIP.Text))
            {
                clsPublic.ShowMessage("输入的IP地址无效", Text);
                return;
            }
            if (clsPublic.CompareToByIP(txtStartIP.Text, txtEndIP.Text)>0)
            {
                clsPublic.ShowMessage("开始IP大于结束IP", Text);
                return;
            }
            
            
            model.BlackIPName = txtName.Text.Trim();
            model.AuthorizeType = cboxType.Text == "黑名单" ;
            model.IsRemoved = IsEnabled.Checked;
            model.StartIP = txtStartIP.Text;
            model.EndIP = txtEndIP.Text;
            model.Description = txtRemark.Text;
            model.SystemId = Models.SqlHelper.Session._SystemId;
            model.CreateTime = DateTime.Now;
            model.OperatorName = Models.SqlHelper.Session._LoginName;
            model.OperatorId = Models.SqlHelper.Session._UserId;
            if (this.Text.Contains("新增"))
            {
                model.Id = Guid.NewGuid();
                if (manager.AddNew(model))
                {
                    clsPublic.ShowMessage("成功",Text);
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.DialogResult = DialogResult.Cancel;
                }
            }
            else
            {
                if (manager.Modify(model))
                {
                    clsPublic.ShowMessage("成功", Text);
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    base.DialogResult = DialogResult.Cancel;
                }
            }
        }

        /// <summary>
        /// 新增用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnAdd_Click(object sender, EventArgs e)
        {
            F_UserForBlackIP_Selectlist sub = new F_UserForBlackIP_Selectlist(model.Id);
            if (sub.ShowDialog() == DialogResult.OK)
            {
                Query();
            }
        }

        /// <summary>
        /// 移除用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnRemove_Click(object sender, EventArgs e)
        {
            object Id = gvUser.GetFocusedRowCellValue("Id");
            if (Id != null)
            {
                var _Id = clsPublic.GetObjGUID(Id);
                if (manager.RemoveUserForBlackIP(_Id))
                {
                    clsPublic.ShowMessage("移除成功",Text);
                    Query();
                }
            }
        }
    }
}
