using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    /// <summary>
    /// 职员任务实体类
    /// </summary>
    public class ys_StaffTasks:BaseEntity
    {
        /// <summary>
        /// 上级任务
        /// </summary>
        public Guid ParentId { get; set; }
        /// <summary>
        /// 任务名称
        /// </summary>
        public string TaskName { get; set; }
        /// <summary>
        /// 描述信息
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 职员ID
        /// </summary>
        public string StaffId { get; set; }
        /// <summary>
        /// 职员名称
        /// </summary>
        public string StaffName { get; set; }
        /// <summary>
        /// 开始日期
        /// </summary>
        public DateTime StartDate { get; set; }
        /// <summary>
        /// 结束日期
        /// </summary>
        public DateTime DueDate { get; set; }
        /// <summary>
        /// 优先级
        /// </summary>
        public int Priority { get; set; } = -1;
        /// <summary>
        /// 是否有描述信息
        /// </summary>
        public bool IsDescription
        {
            get { return !string.IsNullOrEmpty(Description); }
        }
        /// <summary>
        /// 是否完成
        /// </summary>
        public bool IsCompleted
        {
            get { return Progress == 100; }
        }
        /// <summary>
        /// 进度
        /// </summary>
        public int Progress { get; set; } = -1;
    }
}
