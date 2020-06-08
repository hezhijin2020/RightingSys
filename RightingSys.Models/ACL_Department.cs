using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    /// <summary>
    /// 部门实体类
    /// </summary>
    public class ACL_Department:BaseEntity
    {
        /// <summary>
        /// 部门名称
        /// </summary>
        public string DepartmentName { get; set; }

        /// <summary>
        /// 编码(简单编码)
        /// </summary>
     
        public string SimpleCode { get; set; }
        /// <summary>
        /// 排序编码
        /// </summary>
        public string SortCode { get; set; }

        /// <summary>
        /// 父节点Id
        /// </summary>
        
        public Guid ParentId { get; set; }
    }
}
