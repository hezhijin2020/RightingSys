using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RightingSys.Models
{

   /// <summary>
   /// 方法类实体
   /// </summary>
    public class ACL_Function:BaseEntity
    {

        /// <summary>
        /// 方法名称
        /// </summary>
        public string FuncName { get; set; }

        /// <summary>
        /// 授权码
        /// </summary>
        public int FuncHandle { get; set; }

        /// <summary>
        /// 系统ID
        /// </summary>
        public Guid SystemId { get; set; }
    
        public ACL_System System { get; set; }
        /// <summary>
        /// 排序编码
        /// </summary>
        public string SortCode { get; set; }

        /// <summary>
        /// 父节点Id
        /// </summary>
        public Guid ParentId { get; set; }
    }
}
