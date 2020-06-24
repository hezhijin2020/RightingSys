using System;
using System.Collections.Generic;
using System.Linq;

namespace RightingSys.BLL
{
    public class JobFilesManager
    {

        DAL.JobFilesService sev = new DAL.JobFilesService();
        /// <summary>
        /// 新增档案
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(Models.ys_JobFiles model)
        {
            return sev.AddNew(model);
        }

        /// <summary>
        /// 档案删除( 伪删除)
        /// </summary>
        /// <param name="Id">档案ID</param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            return sev.Delete(Id);
        }

        /// <summary>
        /// 获取所有的档案列表
        /// </summary>
        /// <returns></returns>
        public List<Models.ys_JobFiles> GetAllList()
        {
            return sev.GetAllList().Where(a => a.IsRemoved == false).ToList();
        }


        /// <summary>
        /// 有条件的筛选登录日志
        /// </summary>
        /// <param name="SystemId">系统ID</param>
        /// <param name="UserId">用户Id</param>
        /// <param name="startDay">开始日期</param>
        /// <param name="endDay">结束日期</param>
        /// <returns></returns>
        public List<Models.ys_JobFiles> GetList(Guid CategoryId, Guid StaffId, DateTime startDay, DateTime endDay)
        {
            //只有日期 
            if (CategoryId == Guid.Empty && StaffId == Guid.Empty && startDay != null & endDay != null)
            {
                return sev.GetAllList().Where(a => a.IsRemoved == false
                && a.Auditorday >= startDay
                && a.Auditorday <= endDay).ToList();
            }//有用户
            else if (StaffId == Guid.Empty && StaffId != Guid.Empty && startDay != null & endDay != null)
            {
                return sev.GetAllList().Where(a =>
                a.IsRemoved == false
                && a.Auditorday >= startDay
                && a.Auditorday <= endDay
                && a.JobFileStaffId == StaffId).ToList();
            }//有用户有系统
            else if (CategoryId != Guid.Empty && StaffId != Guid.Empty && startDay != null & endDay != null)
            {
                return sev.GetAllList().Where(a =>
                a.IsRemoved == false
                && a.Auditorday >= startDay
                && a.Auditorday <= endDay
                && a.JobFileStaffId == StaffId
                && a.JobFileCategoryId == CategoryId).ToList();
            }//只有系统
            else if (CategoryId != Guid.Empty && StaffId == Guid.Empty && startDay != null & endDay != null)
            {
                return sev.GetAllList().Where(a =>
                a.IsRemoved == false
                && a.Auditorday >= startDay
                && a.Auditorday <= endDay
                && a.JobFileCategoryId == CategoryId).ToList();
            }
            return null;
        }

        /// <summary>
        /// 获取单年指定ID的档案记录
        /// </summary>
        /// <returns></returns>
        public Models.ys_JobFiles GetOneById(Guid Id)
        {
            return sev.GetAllList().FirstOrDefault(a=>a.Id==Id);
        }


        #region 类别方法

        /// <summary>
        /// 新增类别方法
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddNewCategory(Models.ys_JobFileCategory model)
        {
           return sev.AddNewCategory(model);
        }

        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool ModifyCategory(Models.ys_JobFileCategory model)
        {
            return sev.ModifyCategory(model);
        }

        /// <summary>
        /// 删除指定的类别（伪删 除）
        /// </summary>
        /// <param name="ID">类别ID</param>
        /// <returns></returns>
        public bool DeleteCategory(Guid CategoryId)
        {
            return sev.DeleteCategory(CategoryId);
        }

        /// <summary>
        /// 获取指定类别ID实体
        /// </summary>
        /// <returns></returns>
        public Models.ys_JobFileCategory GetOneCategoryById(Guid CategoryId)
        {
            return sev.GetAllListCategory().FirstOrDefault(a=>a.Id==CategoryId);
        }

        /// <summary>
        /// 获取所有的类别列表
        /// </summary>
        /// <returns></returns>
        public List<Models.ys_JobFileCategory> GetAllListCategory()
        {
            return sev.GetAllListCategory().Where(a => a.IsRemoved == false).ToList();
        }
        #endregion


    }
}
