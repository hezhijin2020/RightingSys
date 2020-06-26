using RightingSys.WinForm.Utility.cls;
using System;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageJob
{
    public partial class JobSolutionForm : BaseForm
    {

        /// <summary>
        /// 声明变量
        /// </summary>
        Models.ys_JobRecord model = new Models.ys_JobRecord();
        BLL.JobManager manager = new BLL.JobManager();
        BLL.UserManager Usermanager = new BLL.UserManager();


        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="md">实体</param>
        public JobSolutionForm(Models.ys_JobRecord md)
        {
            InitializeComponent();

            cbBranch.Properties.DataSource = manager.GetDtBranch();
            tlJobCategory.Properties.DataSource = manager.GetAllListCategory();
            cbStaff.Properties.DataSource = Usermanager.GetAllList();

            if (md !=null)
            {
                model = md;
                cbBranch.EditValue = model.BranchId.Trim();
                txtContact.Text = model.Contact;
                cbStaff.EditValue = model.StaffId;
                this.txtDescription.Text = model.Description;
                this.txtCreatorName.Text = model.CreatorName;
                this.txtStartTime.DateTime = model.CreateTime;
            }
        }
        
        /// <summary>
        /// 取消方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btncancel_Click(object sender, EventArgs e)
        {
            base.DialogResult = DialogResult.Cancel;
        }

        /// <summary>
        /// 保存方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            if (tlJobCategory.EditValue != null && txtFaultSolution.Text.Trim() != "")
            {
                model.OperatorId = Models.SqlHelper.Session._UserId;
                model.OperatorName = Models.SqlHelper.Session._FullName;
                model.BranchId = cbBranch.EditValue.ToString();
                model.CategoryId = clsPublic.GetObjGUID(tlJobCategory.EditValue);
                model.CategoryName = tlJobCategory.Text;
                model.Solution = txtFaultSolution.Text;
                model.IsFinish = true;
                model.FinishTime = DateTime.Now;
                model.CreateTime = txtStartTime.DateTime;
                model.TotalMins =System.Convert.ToInt32(clsPublic.DateDiff("m", model.CreateTime, model.FinishTime));
                model.StaffId = clsPublic.GetObjGUID(cbStaff.EditValue);
                model.StaffName = cbStaff.Text;
                model.Contact = txtContact.Text;

                if (manager.Modify(model))
                {
                    base.DialogResult = DialogResult.OK;
                }
                else
                {
                    clsPublic.ShowMessage("失败！", this.Text);
                }
            }
            else
            {
                clsPublic.ShowMessage("故障类型和解决方法不能为空", this.Text);
            }
        }
    }
}
