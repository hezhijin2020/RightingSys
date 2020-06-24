using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
   public class ys_JobFileCategory:BaseEntity
    {
        /// <summary>
        /// 类别名
        /// </summary>
        public string JobFileCategoryName { get; set; }

        /// <summary>
        /// 父节点
        /// </summary>
        public Guid ParentId { get; set; } = Guid.Empty;
    }
}
