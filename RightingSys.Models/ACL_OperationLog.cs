using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    /// <summary>
    /// 用户操作系统日志
    /// </summary>
    public  class ACL_OperationLog:BaseEntity
    {
        /// <summary>
        /// 日志名称
        /// </summary>
      
        public string LogName { get; set; }
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid UserId { get; set; }
        /// <summary>
        ///用户名
        /// </summary>
     
        public string LoginName { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
       
        public string FullName { get; set; }
        /// <summary>
        /// 部门
        /// </summary>
       
        public string DepartmentName { get; set; }
        /// <summary>
        /// 部门ID
        /// </summary>
        public Guid DepartmentId { get; set; }
        /// <summary>
        /// 登录IP
        /// </summary>
       
        public string LoginIP { get; set; }
        /// <summary>
        /// 登录MAC
        /// </summary>
       
        public string LoginMac { get; set; }
        /// <summary>
        /// 系统ID
        /// </summary>
        public Guid SystemId { get; set; }
        /// <summary>
        /// 系统名称
        /// </summary>
        
        public string SystemName { get; set; }

        /// <summary>
        /// 操作类型 
        /// </summary>
       
        public string OperationType { get; set; }

        /// <summary>
        /// SQL命令
        /// </summary>
      
        public string SqlCommand { get; set; }
        /// <summary>
        /// 表名
        /// </summary>
      
        public string OperationTable { get; set; }
    }
}
