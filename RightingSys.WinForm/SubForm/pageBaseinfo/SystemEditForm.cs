using RightingSys.WinForm.Utility.cls;
using System;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    public partial class SystemEditForm :BaseForm
    {
        RightingSys.BLL.SystemManager systemMg = new RightingSys.BLL.SystemManager();
        Models.ACL_System model = new Models.ACL_System();
        public SystemEditForm()
        { 
            InitializeComponent();
            txtsysID.Text = "新Id";
        }

        public SystemEditForm(Guid Id)
        {
            InitializeComponent();
            model = systemMg.GetOneById(Id);
            txtsysID.Text = model.Id.ToString();
            txtsysName.Text = model.SystemName;
            txtSortCode.Text = model.SortCode;
            txtSimpleCode.Text = model.SimpleCode;
            txtRemark.Text = model.SystemDescription;
        }

        public bool PerSave()
        {
            bool count = false;
            if (txtsysName.Text.Trim()=="")
            {
                clsPublic.ShowMessage("系统名称不能为空！",Text);
                txtsysName.Focus();
                return count;
            }
            if (txtsysID.Text=="新Id")
            {
                if (systemMg.ExistsByName(txtsysName.Text.Trim()))
                {
                    clsPublic.ShowMessage("系统名称已经存在！", Text);
                    txtsysName.Focus();
                    return count;
                }
            }

           
            model.SystemName = txtsysName.Text.Trim();
            model.SimpleCode = txtSimpleCode.Text;
            model.SortCode = txtSortCode.Text;
            model.SystemDescription = txtRemark.Text;

            if (txtsysID.Text == "新Id")
            {
                model.Id = Guid.NewGuid();
                count = systemMg.AddNew(model);
                clsPublic.ShowMessage("新增成功！", Text);
            }
            else {
                count = systemMg.Modify(model);
                clsPublic.ShowMessage("修改成功！", Text);
            }
            return count;
        }

        private void btnNewAdd_Click(object sender, EventArgs e)
        {
            if (PerSave())
            {
                txtsysID.Text = "";
                txtsysName.Text = "";
                txtSortCode.Text ="";
                txtSimpleCode.Text = "";
                txtRemark.Text = "";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (PerSave())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
