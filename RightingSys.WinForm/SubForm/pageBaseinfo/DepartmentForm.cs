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

        /// <summary>
        /// 新增方法
        /// </summary>
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

        /// <summary>
        /// 删除方法
        /// </summary>
        public override void Delete()
        {
            TreeListNode node = tlDepartment.FocusedNode;
            if (node != null)
            {
                if (node.Nodes.Count > 0)
                {
                    clsPublic.ShowMessage("该机构下面有子机构，不能删除！");
                }
                else
                {
                   Guid DepartmentId= (Guid)node.GetValue("Id");
                    if (deptMg.ExistsUserById(DepartmentId))
                    {
                        clsPublic.ShowMessage("该机构下面有用户，不能删除！");
                        return;
                    }
                    else
                    {
                        if(clsPublic.GetMessageBoxYesNoResult("是否删除该机构，删除将不能恢复？","提示"))
                        {
                            if (deptMg.Delete(DepartmentId))
                            {
                                Models.ACL_Department model = dtAll.Find(s => s.Id.Equals(clsPublic.GetObjGUID(DepartmentId)));
                                dtAll.Remove(model);
                                tlDepartment.RefreshDataSource();
                                tlPID.Properties.TreeList.RefreshDataSource();
                                clsPublic.ShowMessage("删除成功！");
                            }
                            else
                            {
                                clsPublic.ShowMessage("删除失败！");
                            }
                        }
                    }
                }
            }
        }

        /// <summary>
        /// 查询方法
        /// </summary>
        public override void Query()
        {
            dtAll = deptMg.GetAllList();
            tlDepartment.DataSource = tlPID.Properties.DataSource = dtAll;
            tlDepartment.ExpandAll(); 
        }

        /// <summary>
        /// 新增修改保存方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnSave_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "" || tlPID.EditValue == null)
            {
                clsPublic.ShowMessage("机构名和上级机构不能为空", "提示");
                txtName.Focus();
                return;
            }
            else
            {
                if (model.Id == (Guid)tlPID.EditValue)
                {
                    clsPublic.ShowMessage("节点的父节点不能为当前节点！", "提示");
                    tlPID.Focus();
                    return;
                }
                model.DepartmentName = txtName.Text.Trim();
                model.ParentId = clsPublic.GetObjGUID(tlPID.EditValue);
                model.SimpleCode = txtHandNo.Text.Trim();
                model.IsRemoved = false;
                model.CreateTime = clsPublic.ToDateTime(txtCreatTime.Text.Trim());
                model.SortCode = txtSortCode.Text;
     
                if (!clsPublic.IsGuid(txtID.Text))
                {
                    model.Id = Guid.NewGuid();
                    if (deptMg.AddNew(model))
                    {
                        dtAll.Add(model);
                        tlDepartment.RefreshDataSource();
                        tlPID.Properties.TreeList.RefreshDataSource();
                        clsPublic.ShowMessage("新增成功", "提示");
                    }
                    else
                    {
                        clsPublic.ShowMessage("新增失败", "提示");
                    }
                }
                else
                {
                    model.Id = clsPublic.GetObjGUID(txtID.Text);
                    if (deptMg.Modify(model))
                    {
                        tlDepartment.RefreshDataSource();
                        tlPID.Properties.TreeList.RefreshDataSource();
                        clsPublic.ShowMessage("修改成功", "提示");
                    }
                    else
                    {
                        
                        clsPublic.ShowMessage("修改失败", "提示");
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

                gcDataRole.DataSource = deptMg.GetRoleListByDepartmentId(clsPublic.GetObjGUID(ID));
                gcDataUser.DataSource = deptMg.GetUserListByDepartmentId(clsPublic.GetObjGUID(ID));

                if (node.GetValue("DepartmentName").ToString() != "株洲紫气东来商贸有限公司")
                {
                    sbtnSave.Enabled = true;
                }
                else { sbtnSave.Enabled = false; }

            }
        }
    }
}
