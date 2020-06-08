using DevExpress.XtraTreeList.Nodes;
using RightingSys.WinForm.Utility.cls;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
namespace RightingSys.WinForm.SubForm.pageBaseinfo
{
    public partial class DepartmentForm : BaseForm
    {

        Models.ACL_Department model = new Models.ACL_Department();
        RightingSys.BLL.DepartmentManager deptMg = new RightingSys.BLL.DepartmentManager();
        private List<Models.ACL_Department> dtAll;

        public DepartmentForm()
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
            model = new Models.ACL_Department();
            txtID.Text ="新ID";
            txtName.Text = "";
            txtCreatTime.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            txtSortCode.Text = "";
            tlPID.EditValue = null;
            txtHandNo.EditValue = "";
            sbtnSave.Enabled = true;
        }
        public override void Delete()
        {
            TreeListNode node = tlDepartment.FocusedNode;
            if (node != null)
            {
                if (node.Nodes.Count > 0)
                {
                    MessageBox.Show("该机构下面有子机构，不能删除！");
                }
                else
                {
                   Guid DepartmentId= (Guid)node.GetValue("Id");
                    if (deptMg.ExistsUserById(DepartmentId))
                    {
                        MessageBox.Show("该机构下面有用户，不能删除！");
                        return;
                    }
                    else
                    {
                        if(MessageBox.Show("是否删除该机构，删除将不能恢复？","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            if (deptMg.Delete(DepartmentId))
                            {
                                Models.ACL_Department model = dtAll.Find(s => s.Id.Equals(clsPublic.GetObjGUID(DepartmentId)));
                                dtAll.Remove(model);
                                tlDepartment.RefreshDataSource();
                                tlPID.Properties.TreeList.RefreshDataSource();
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
            dtAll = deptMg.GetAllList();
            //dtAll.Sort((a, b) => a.SortCode.CompareTo(b.SortCode));
            tlDepartment.DataSource = tlPID.Properties.DataSource = dtAll;
            tlDepartment.ExpandAll(); 
        }
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || tlPID.EditValue == null)
            {
                MessageBox.Show("机构名和上级机构不能为空", "提示");
                txtName.Focus();
                return;
            }
            else
            {
                if (model.Id == (Guid)tlPID.EditValue)
                {
                    MessageBox.Show("节点的父节点不能为当前节点！", "提示");
                    tlPID.Focus();
                    return;
                }
                model.DepartmentName = txtName.Text.Trim();
                model.ParentId = clsPublic.GetObjGUID(tlPID.EditValue);
                model.SimpleCode = txtHandNo.Text.Trim();
                model.IsRemoved = false;
                model.CreateTime = clsPublic.ToDateTime(txtCreatTime.Text.Trim());
                model.SortCode = txtSortCode.Text;
     

                //if (cboxCategory.EditValue.ToString() == "公司" || cboxCategory.EditValue.ToString() == "集团")
                //{
                //    model.CompanyName = model.Name;
                //    model.Company_ID = model.ID;
                //}

                if (!clsPublic.IsGuid(txtID.Text))
                {
                    model.Id = Guid.NewGuid();
                    if (deptMg.AddNew(model))
                    {
                        dtAll.Add(model);
                        tlDepartment.RefreshDataSource();
                        tlPID.Properties.TreeList.RefreshDataSource();
                        MessageBox.Show("新增成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "提示");
                    }
                }
                else
                {
                    model.Id = clsPublic.GetObjGUID(txtID.Text);
                    if (deptMg.Modify(model))
                    {
                        tlDepartment.RefreshDataSource();
                        tlPID.Properties.TreeList.RefreshDataSource();
                        MessageBox.Show("修改成功", "提示");
                    }
                    else
                    {
                        MessageBox.Show("修改失败", "提示");
                    }
                }
            }
        }
       
      
        private void tlOU_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            if (e.Node != null)
            {
               TreeListNode node = e.Node;
               object ID = e.Node.GetValue("Id");
               object PID = e.Node.GetValue("ParentId");
               model =dtAll.Find(s=>s.Id.Equals(ID));
               txtID.EditValue = model.Id;
               txtName.Text = model.DepartmentName;
               txtCreatTime.EditValue = model.CreateTime;
               txtHandNo.Text = model.SimpleCode;
               txtSortCode.Text = model.SortCode;
                tlPID.EditValue = model.ParentId;

                //gcRole.DataSource = bll.GetRoleForOu(clsPublic.GetObjGUID(ID));
                //gcUser.DataSource = bll.GetUserForOu(clsPublic.GetObjGUID(ID));

                if (node.GetValue("DepartmentName").ToString() != "株洲紫气东来商贸有限公司")
                {
                    sbtnSave.Enabled = true;
                }
                else { sbtnSave.Enabled = false; }

            }
        }
    }
}
