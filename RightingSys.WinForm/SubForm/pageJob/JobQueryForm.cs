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
    public partial class JobQueryForm : BaseForm
    {
        BLL.JobManager manager = new BLL.JobManager();

        public JobQueryForm()
        {
            InitializeComponent();

            cbBranch.Properties.DataSource = manager.GetDtBranch();
            tlJobCategory.Properties.DataSource = manager.GetAllListCategory();
            dStart.DateTime = DateTime.Now.Date.AddDays(-7);
            dEnd.DateTime = DateTime.Now.Date;

        }

        /// <summary>
        /// 功能初始化
        /// </summary>
        public override void InitFeatureButton()
        {
            base.SetFeatureButton(new FeatureButton[] { FeatureButton.Query,FeatureButton.Export});
        }

        /// <summary>
        /// 查询
        /// </summary>
        public override void Query()
        {
            gcData.DataSource = manager.GetList(clsPublic.GetObjectString(cbBranch.EditValue),clsPublic.GetObjGUID(tlJobCategory.EditValue), dStart.DateTime.Date,dEnd.DateTime.Date.AddDays(1));
        }

        /// <summary>
        /// 导出
        /// </summary>
        public override void Export()
        {
            base.Export();
        }
    }
}
