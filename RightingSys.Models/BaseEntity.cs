using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    /// <summary>
    /// 模型层实体基类
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// 编号
        /// </summary>
        public Guid Id { get; set; }

        //操作员ID
        public Guid OperatorId { get; set; }

        /// <summary>
        /// 操作员
        /// </summary>
        public string OperatorName { get; set; }


        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; } = DateTime.Now;

        /// <summary>
        /// 是否删除（伪删除）
        /// </summary>
        public bool IsRemoved { get; set; } = false;
    }
}
