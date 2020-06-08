using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    /// <summary>
    /// 角色实体
    /// </summary>
    public class ACL_Role:BaseEntity
    {
        /// <summary>
        /// 角色名称
        /// </summary>
        
        public string RoleName { get; set; }

        /// <summary>
        /// 编码(简单编码)
        /// </summary>

        public string SimpleCode { get; set; } = "";
        /// <summary>
        /// 排序编码
        /// </summary>

        public string SortCode { get; set; } = "";

        /// <summary>
        /// 父节点Id
        /// </summary>

        public Guid ParentId { get; set; } = Guid.Empty;
    }
}
