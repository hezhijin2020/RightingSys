using RightingSys.WinForm.Utility.cls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RightingSys.WinForm.SubForm.pageJob
{
    public partial class JobAnalyzeForm : BaseForm
    {

        BLL.JobManager manager = new BLL.JobManager();

        public JobAnalyzeForm()
        {
            InitializeComponent();

            cbBranch.Properties.DataSource = manager.GetDtBranch();
            dStart.DateTime = DateTime.Now.Date.AddDays(-7);
            dEnd.DateTime = DateTime.Now.Date;
        }

        /// <summary>
        /// 功能初始化
        /// </summary>
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(FeatureButton.Query);
        }

        /// <summary>
        /// 查询功能
        /// </summary>
        public override void Query()
        {


            string where = "  and  ";
            if (cbBranch.EditValue != null)
            {
                where += "  a.BranchId='" + cbBranch.EditValue.ToString() + "' and  ";
            }
            if (dEnd.DateTime < dStart.DateTime)
            {
               clsPublic.ShowMessage("开始时间大于结束时间！", Text); return;
            }
            where += " a.CreateTime>'" + dStart.DateTime.Date + "' and a.CreateTime<'" + dEnd.DateTime.Date.AddDays(1) + "'";
            pgcMain.DataSource = manager.GetDtAnalyzeJob(where);
        }
    }
}
