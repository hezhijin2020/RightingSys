using RightingSys.WinForm.Utility.cls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageJob
{
    public partial class JobRecordForm : BaseForm
    {

        BLL.JobManager manager = new BLL.JobManager();
        Models.ys_JobRecord model = new Models.ys_JobRecord();
        BLL.UserManager userManager = new BLL.UserManager();

        /// <summary>
        /// 构造函数，控件的初始化
        /// </summary>
        public JobRecordForm()
        {
            InitializeComponent();

            lkpStaff.Properties.DataSource = userManager.GetAllList();
            lkpBranch.Properties.DataSource = manager.GetDtBranch();
            txtCreator.Text = Models.SqlHelper.Session._LoginName;
        }

        /// <summary>
        /// 功能初始化
        /// </summary>
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[]
            {
                FeatureButton.Query,
                FeatureButton.Modify,
                FeatureButton.Delete
            });
        }

        /// <summary>
        /// 修改
        /// </summary>
        public override void Modify()
        {
            if (gvData.FocusedRowHandle >= 0)
            {
                Guid Id = clsPublic.GetObjGUID(gvData.GetFocusedRowCellValue("Id"));
                var md = manager.GetOneById(Id);
                JobSolutionForm sub = new JobSolutionForm(md);
                if (DialogResult.OK == sub.ShowDialog())
                {
                    Query();
                }
            }
        }

        /// <summary>
        /// 删除功能
        /// </summary>
        public override void Delete()
        {
            if (gvData.FocusedRowHandle >= 0)
            {
                if (clsPublic.GetMessageBoxYesNoResult("记录删除后不可找回，是否删除？", Text))
                {
                    Guid Id = clsPublic.GetObjGUID(gvData.GetFocusedRowCellValue("Id"));
                    if (manager.Delete(Id))
                    {
                        Query();
                    }
                    else
                    {
                        clsPublic.ShowMessage("删除失败！", Text);
                    }
                }
            }
        }

        /// <summary>
        /// 查询功能
        /// </summary>
        public override void Query()
        {
            gcData.DataSource = manager.GetNotFinishList();
        }
        
        /// <summary>
        /// 双击修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void gvData_MouseDown(object sender, MouseEventArgs e)
        {
            DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo hInfo = this.gvData.CalcHitInfo(new Point(e.X, e.Y));
            if (e.Button == MouseButtons.Left && e.Clicks == 2)
            {
                //判断光标是否在行范围内 
                if (hInfo.InRow)
                {
                    Modify();
                }
            }
        }

        /// <summary>
        /// 选项更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbtnGS_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnGS.Checked)
            {
                lkpBranch.EditValue = "GAHN_BM   ";
                lkpStaff.Enabled = true;
                lkpBranch.Enabled = false;

            }
            else
            {
                lkpBranch.EditValue = null;
                lkpStaff.Enabled = false;
                lkpStaff.EditValue = null;
                lkpBranch.Enabled = true;
            }
        }

        /// <summary>
        /// 新增记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (lkpBranch.EditValue != null&&txtDescription.Text.Trim()!="")
            {
                model.BranchId = clsPublic.GetObjectString(lkpBranch.EditValue).Trim();
                model.BranchName = lkpBranch.Text;
                model.Contact = txtContact.Text;
                model.Description =txtDescription.Text.Trim();
                model.CreatorId = Models.SqlHelper.Session._UserId;
                model.CreatorName = Models.SqlHelper.Session._FullName;
                model.StaffId = clsPublic.GetObjGUID(lkpStaff.EditValue);
                model.StaffName = lkpStaff.Text;
                if (manager.AddNew(model))
                {
                    Query();
                }
                else
                {
                    clsPublic.ShowMessage("失败！", this.Text);
                }

                txtDescription.Text = "";
                txtContact.Text = "";

            }
            else
            {
               clsPublic.ShowMessage("店铺和问题描述不能为空！", this.Text);
            }
        }
    }
}
