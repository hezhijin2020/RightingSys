using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    /// <summary>
    /// 角色权限表
    /// </summary>
    public class ACL_Role_Function:BaseEntity
    {
        /// <summary>
        /// 角色ID
        /// </summary>
        public Guid RoleId { get; set; }

        public string RoleName { get; set; }

        /// <summary>
        /// 方法ID
        /// </summary>
        public Guid FunctionId { get; set; }

        public string FuncName { get; set; }

        /// <summary>
        /// 操作权限
        /// </summary>
        public int OpCode { get; set; }
    }
}
