using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    /// <summary>
    /// 指纹信息实体类
    /// </summary>
    public class ACL_FingerPrint:BaseEntity
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        public Guid UserId { get; set; } = Guid.NewGuid();

        public string FullName { get; set; }

        /// <summary>
        /// 指纹数据
        /// </summary>
        public byte[] FingerData { get; set; }

        /// <summary>
        /// 指纹描述
        /// </summary>
        public string FingerDescription { get; set; }
    }
}
