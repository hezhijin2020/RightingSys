using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    /// <summary>
    /// 角色部门表
    /// </summary>
    public class ACL_Role_Department:BaseEntity
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public Guid RoleId { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public Guid DepartmentId { get; set; }
    }
}
