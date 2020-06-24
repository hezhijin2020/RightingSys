using System;

namespace RightingSys.Models
{
    /// <summary>
    /// 工作类别
    /// </summary>
    public class ys_JobCategory:BaseEntity
    {
        /// <summary>
        /// 类别名
        /// </summary>
        public string JobCategoryName { get; set; }

        /// <summary>
        /// 父节点
        /// </summary>
        public Guid ParentId { get; set; } = Guid.Empty;
    }
}
