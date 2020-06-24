using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    /// <summary>
    /// 工作记录
    /// </summary>
    public class ys_JobRecord
    {
        /// <summary>
        /// 机构编号
        /// </summary>
        public string BranchId { get; set; }
        /// <summary>
        /// 机构名
        /// </summary>
        public string BranchName { get; set; }

        /// <summary>
        /// 职员ID
        /// </summary>
        public Guid StaffId { get; set; } = Guid.Empty;
        /// <summary>
        /// 职员名称
        /// </summary>
        public string StaffName { get; set; } = "";

        /// <summary>
        /// 类别ID
        /// </summary>
        public Guid CategoryId { get; set; }
        /// <summary>
        /// 类别名称
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// 工作描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///创建者
        /// </summary>
        public Guid CreatorId { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        public string CreatorName { get; set; }

        /// <summary>
        /// 解决方案
        /// </summary>
        public string Solution { get; set; }
        /// <summary>
        /// 完成时间
        /// </summary>
        public DateTime FinishTime { get; set; } = DateTime.Now;
        
        /// <summary>
        /// 用时
        /// </summary>
        public int TotalMins { get; set; } = 0;

        /// <summary>
        /// 是否完成
        /// </summary>
        public bool IsFinish { get; set; } = false;

    }
}
