using System;
using System.Collections.Generic;

namespace RightingSys.Models
{
    public class ACL_BlackIP:BaseEntity
    {
        /// <summary>
        /// 规则名称
        /// </summary>
        public string BlackIPName { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        public bool AuthorizeType { get; set; }

        /// <summary>
        /// 开始IP
        /// </summary>
        public string StartIP { get; set; }

        /// <summary>
        /// 结束IP
        /// </summary>
        public string EndIP { get; set; }

        /// <summary>
        /// 操作员ID
        /// </summary>
        public Guid OperatorId { get; set; }

        /// <summary>
        /// /// <summary>
        /// 操作员
        /// </summary>
        /// </summary>
        public string OperatorName { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 系统Id
        /// </summary>
        public Guid SystemId { get; set; }

        /// <summary>
        ///系统名称
        /// </summary>
        public string SystemName { get; set; }

        /// <summary>
        /// 用户列表
        /// </summary>
        public List<Models.ACL_BlackIP_User> Details { get; set; }
    }
}
