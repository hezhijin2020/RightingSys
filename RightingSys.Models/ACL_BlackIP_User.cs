using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    public class ACL_BlackIP_User:BaseEntity
    {
        /// <summary>
        /// 规则ID
        /// </summary>
        public Guid BlackIPId { get;set; }

        /// <summary>
        /// 用户Id
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        /// 用户编号
        /// </summary>
        public string UserSimpleCode { get; set; }
       /// <summary>
       /// 所属部门
       /// </summary>
        public string DepartmentName { get; set; }
        /// <summary>
        /// 登录名称
        /// </summary>
        public string LoginName { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string UserName { get; set; }

    }
}
