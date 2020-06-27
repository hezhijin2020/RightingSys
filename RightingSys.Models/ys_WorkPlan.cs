using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    public class ys_WorkPlan:BaseEntity
    {
        /// <summary>
        /// 计划
        /// </summary>
        public string WorkPlan { get; set; } = "公司";

        /// <summary>
        /// 检视
        /// </summary>
        public string CheckPlan { get; set; } = "公司";

        /// <summary>
        /// 日期
        /// </summary>
        public DateTime WorkDay { get; set; }

        /// <summary>
        /// 职员
        /// </summary>
        public Guid StaffId { get; set; }

        /// <summary>
        /// 职员
        /// </summary>
        public string StaffName { get; set; }

        /// <summary>
        /// 工作重点
        /// </summary>
        public string FocusWork { get; set; }
    }
}
