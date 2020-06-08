
using DevExpress.XtraTreeList.Nodes;
using RightingSys.WinForm.AppPublic;
using RightingSys.WinForm.Utility.cls;
using RightingSys.WinForm.Utility.ToolForm;
using System;
using System.Data;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    public partial class FunctionForm :BaseForm
    {

        RightingSys.BLL.FunctionManager funcManage = new RightingSys.BLL.FunctionManager();
        Models.ACL_Function model = new Models.ACL_Function();
        private DataTable dtAll = new DataTable();

        public FunctionForm()
        {
            InitializeComponent();
            Query();
        }
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[] { FeatureButton.Add,FeatureButton.Delete,FeatureButton.Query});
        }
        public override void AddNew()
        {
            txtID.Text = "新ID";
            txtSortCode.Text = "";
            txtName.Text = "";
            txtFuncHandle.Text = "";
            txtFuncHandle.Tag = 0;
            tlPID.EditValue = null;
            sbtnSave.Enabled = true;
            model = new Models.ACL_Function();
        }
        public override void Delete()
        {
            TreeListNode node = tlFunc.FocusedNode;
            if (node != null)
            {
                if (node.Nodes.Count > 0)
                {
                    MessageBox.Show("该功能下面有子功能，不能删除！");
                }
                else
                {
                    Guid Id = (Guid)node.GetValue("Id");
                    if (funcManage.ExistsRoleById(Id))
                    {
                        MessageBox.Show("该功能已被引用，不能删除！");
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("是否删除该功能，删除将不能恢复？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            if (funcManage.Delete(Id))
                            {
                                Query();
                                MessageBox.Show("删除成功！");
                            }
                            else
                            {
                                MessageBox.Show("删除失败！");
                            }
                        }
                    }
                }
            }
        }
        public override void Query()
        {
            dtAll =funcManage.GetTbFunctionTree();
            tlPID.Properties.DataSource=tlFunc.DataSource = dtAll;
            tlFunc.ExpandAll();
        }
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == ""||tlPID.EditValue==null)
            {
                MessageBox.Show("机构名和上级机构不能为空", "提示");
                txtName.Focus();
                return;
            }
            else
            {

              
                if (model == null)
                {
                    MessageBox.Show("请点新增或选择要修改的功能节点在点保存！");return;
                }

                if (model.Id == (Guid)tlPID.EditValue)
                {
                    MessageBox.Show("节点的父节点不能为当前节点！", "提示");
                    tlPID.Focus();
                    return;
                }
                model.FuncName = txtName.Text.Trim();
                model.ParentId = clsPublic.GetObjGUID(tlPID.EditValue);
                model.SortCode = txtSortCode.Text;
                model.FuncHandle =Convert.ToInt32(txtFuncHandle.Tag);
                model.SystemId = clsPublic.GetObjGUID(dtAll.Select(String.Format("Id='{0}'",tlPID.EditValue))[0]["SystemId"]);
                if (!clsPublic.IsGuid(txtID.Text))
                {
                    model.Id = Guid.NewGuid();
                    if (funcManage.AddNew(model))
                    {
                        Query();
                        MessageBox.Show("新增成功", "提示");
                    }
                    else
                    {
                        Query();
                        MessageBox.Show("修改失败", "提示");
                    }
                }
                else
                {
                    model.Id = clsPublic.GetObjGUID(txtID.Text);
                    if (funcManage.Modify(model))
                    {
                        Query();
                        MessageBox.Show("修改成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "提示");
                    }
                }
            }
        }
        private void tlFunc_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
                TreeListNode node = e.Node;
                object Id = e.Node.GetValue("Id");
                model = funcManage.GetOneFuncionById((Guid)Id);
                if (model == null) return;
                txtID.EditValue = model.Id;
                txtSortCode.Text = model.SortCode;
                txtName.Text = model.FuncName;
                txtFuncHandle.Text = funcManage.GetFuncHandleText(model.FuncHandle);
                txtFuncHandle.Tag = model.FuncHandle;
                tlPID.EditValue = model.ParentId;
                if (model.ParentId == Guid.Empty || model.ParentId == null)
                {
                    sbtnSave.Enabled = false;
                }
                else
                {
                    sbtnSave.Enabled = true;
                }
            }
        }
        private void txtFuncHandle_Click(object sender, EventArgs e)
        {

            F_Func_Selectlist sub = new F_Func_Selectlist(txtFuncHandle.Tag);
            if (sub.ShowDialog() == DialogResult.OK)
            {
                txtFuncHandle.Tag = sub.FuncHandle;
                txtFuncHandle.Text = sub.SelectText;
            }
        }

    }
}
