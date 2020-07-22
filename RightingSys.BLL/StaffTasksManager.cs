using System;
using System.Collections.Generic;
using System.Linq;

namespace RightingSys.BLL
{
    /// <summary>
    /// 任务管理类
    /// </summary>
    public  class StaffTasksManager
    {
        DAL.StaffTasksService sev = new DAL.StaffTasksService();
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddNew(Models.ys_StaffTasks model)
        {
            return sev.AddNew(model);
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Modify(Models.ys_StaffTasks model)
        {
            return sev.Modify(model);
        }

        /// <summary>
        /// 删除(伪删除)
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            return sev.Delete(Id);
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public List<Models.ys_StaffTasks> GetAllList()
        {
            return sev.GetAllList().Where(a => a.IsRemoved == false).ToList();
        }

        /// <summary>
        /// 获取指定ID的实体信息
        /// </summary>
        /// <returns></returns>
        public Models.ys_StaffTasks GetOneById(Guid Id)
        {
            return GetAllList().FirstOrDefault(a => a.Id == Id);
        }
    }
}
