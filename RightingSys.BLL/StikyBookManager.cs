using System;
using System.Collections.Generic;
using System.Linq;

namespace RightingSys.BLL
{
    public  class StikyBookManager
    {

        DAL.StickyBookService sev = new DAL.StickyBookService();

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(Models.ys_StickyBook model)
        {
           return sev.AddNew(model);
        }

        /// <summary>
        /// 修改便签信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Modify(Models.ys_StickyBook model)
        {
            return sev.Modify(model);
        }

        /// <summary>
        /// 删除便笺
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            return sev.Delete(Id);
        }

        /// <summary>
        /// 获取信息列表
        /// </summary>
        /// <returns></returns>
        public List<Models.ys_StickyBook> GetAllList()
        {
            return  sev.GetAllList().Where(a => a.IsRemoved == false).ToList();
        }

        /// <summary>
        /// 获取指定ID的实体信息
        /// </summary>
        /// <returns></returns>
        public Models.ys_StickyBook GetOneById(Guid Id)
        {
            return GetAllList().FirstOrDefault(a => a.Id == Id);
        }
    }
}
