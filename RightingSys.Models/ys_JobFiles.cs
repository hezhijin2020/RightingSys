using System;

namespace RightingSys.Models
{
    public class ys_JobFiles:BaseEntity
    {
        /// <summary>
        /// 档案名
        /// </summary>
        public string JobFileName { get; set; }
        /// <summary>
        /// 类别
        /// </summary>
        public Guid JobFileCategoryId { get; set; }
        /// <summary>
        ///类别名
        /// </summary>
        public string JobFileCategoryName { get; set; }
        /// <summary>
        /// 职员
        /// </summary>
        public Guid JobFileStaffId { get; set; }
        /// <summary>
        /// 职员名
        /// </summary>
        public string JobFileStaffName { get; set; }

        /// <summary>
        /// 档案
        /// </summary>
        public byte[] FileImage { get; set; }

        /// <summary>
        /// 审核人ID
        /// </summary>
        public Guid AuditorId { get; set; }

        /// <summary>
        /// 审核人
        /// </summary>
        public string AuditorName { get; set; }

        /// <summary>
        /// 审核时间
        /// </summary>
        public DateTime Auditorday { get; set; } = DateTime.Now;

        /// <summary>
        ///描述
        /// </summary>
        public string Description { get; set; }
    }
}
