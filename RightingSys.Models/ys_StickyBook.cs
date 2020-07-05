using System;

namespace RightingSys.Models
{
    public class ys_StickyBook:BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string  StickyName    {get;set;}
        /// <summary>
        /// 机构编号
        /// </summary>
        public string  BranchId     {get;set;}
        /// <summary>
        /// 机构名称
        /// </summary>
        public string  BranchName   {get;set;}
        /// <summary>
        /// 类别
        /// </summary>
        public string  CategoryName {get;set;}
        /// <summary>
        /// 职员Id
        /// </summary>
        public Guid  StaffId      {get;set;}
        /// <summary>
        /// 职员
        /// </summary>
        public string  StaffName    {get;set;}
        /// <summary>
        /// 信息
        /// </summary>
        public string  StickyXML     {get;set;}
        /// <summary>
        /// 更改时间
        /// </summary>
        public DateTime EditTime { get; set; }

    }
}
