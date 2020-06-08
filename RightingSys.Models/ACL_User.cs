using System;
using System.Collections.Generic;
using System.Linq;

namespace RightingSys.Models
{
    /// <summary>
    /// 用户类
    /// </summary>
    public class ACL_User:BaseEntity
    {

        /// <summary>
        /// 登录名称
        /// </summary>
 
        public string LoginName { get; set; }

        /// <summary>
        /// 登录密码
        /// </summary>
        public string LoginPwd { get; set; } = "123";

        public string SimpleCode { get; set; }

        /// <summary>
        /// 部门ID
        /// </summary>
        public Guid DepartmentId { get; set; }

        /// <summary>
        /// 部门名称 不存在user表
        /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string FullName { get; set; }
       
    }
}
