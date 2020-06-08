using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{
    /// <summary>
    /// 系统实体
    /// </summary>
    public class ACL_System:BaseEntity
    {

        /// <summary>
        /// 系统名称
        /// </summary>

        public string SystemName { get; set; }

        /// <summary>
        /// 编码(简单编码)
        /// </summary>
        public string SimpleCode { get; set; }
        /// <summary>
        /// 排序编码
        /// </summary>
        public string SortCode { get; set; }

        /// <summary>
        ///系统描述
        /// </summary>
        public string  SystemDescription { get; set; }

        /// <summary>
        /// 更新地址
        /// </summary>
        public string URL { get; set; } = "ftp://172.20.58.5:8017/SoftUpdate/";

        /// <summary>
        /// 版本信息
        /// </summary>
        public string Version { get; set; } = "1.0.01";

        /// <summary>
        /// 最后更新时间
        /// </summary>
        public DateTime LastTime { get; set; } = DateTime.Now;
    }
}
