using System;
using System.Collections.Generic;
using System.Linq;

namespace RightingSys.BLL
{
    public class JobManager
    {

        DAL.JobService sev = new DAL.JobService();
        /// <summary>
        /// 新增工作记录
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(Models.ys_JobRecord model)
        {
            return sev.AddNew(model);
        }


        /// <summary>
        /// 修改工作记录
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool Modify(Models.ys_JobRecord model)
        {
            return sev.Modify(model);
        }

        /// <summary>
        /// 工作记录删除( 伪删除)
        /// </summary>
        /// <param name="Id">工作记录ID</param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            return sev.Delete(Id);
        }

        /// <summary>
        /// 获取所有的工作记录列表
        /// </summary>
        /// <returns></returns>
        public List<Models.ys_JobRecord> GetAllList()
        {
            return sev.GetAllList().Where(a => a.IsRemoved == false).ToList();
        }

        /// <summary>
        /// 获取未完成的工作记录列表
        /// </summary>
        /// <returns></returns>
        public List<Models.ys_JobRecord> GetNotFinishList()
        {
            return sev.GetAllList().Where(a => a.IsRemoved == false && a.IsFinish==false).ToList();
        }


        /// <summary>
        /// 有条件的筛选登录日志
        /// </summary>
        /// <param name="SystemId">系统ID</param>
        /// <param name="UserId">用户Id</param>
        /// <param name="startDay">开始日期</param>
        /// <param name="endDay">结束日期</param>
        /// <returns></returns>
        public List<Models.ys_JobRecord> GetList(string BranchId, Guid CategoryId, DateTime startDay, DateTime endDay)
        {
            //只有日期 
            if (CategoryId == Guid.Empty && BranchId == "" && startDay != null & endDay != null)
            {
                return sev.GetAllList().Where(a => a.IsRemoved == false
                && a.CreateTime >= startDay
                && a.CreateTime <= endDay).ToList();
            }//有用户
            else if (CategoryId == Guid.Empty && BranchId != "" && startDay != null & endDay != null)
            {
                return sev.GetAllList().Where(a =>
                a.IsRemoved == false
                && a.CreateTime >= startDay
                && a.CreateTime <= endDay
                && a.BranchId == BranchId).ToList();
            }//有用户有系统
            else if (CategoryId != Guid.Empty && BranchId != "" && startDay != null & endDay != null)
            {
                return sev.GetAllList().Where(a =>
                a.IsRemoved == false
                && a.CreateTime >= startDay
                && a.CreateTime <= endDay
                && a.BranchId == BranchId
                && a.CategoryId == CategoryId).ToList();
            }//只有系统
            else if (CategoryId != Guid.Empty && BranchId == "" && startDay != null & endDay != null)
            {
                return sev.GetAllList().Where(a =>
                a.IsRemoved == false
                && a.CreateTime >= startDay
                && a.CreateTime <= endDay
                && a.CategoryId == CategoryId).ToList();
            }
            return null;
        }

        /// <summary>
        /// 获取单年指定ID的工作记录记录
        /// </summary>
        /// <returns></returns>
        public Models.ys_JobRecord GetOneById(Guid Id)
        {
            return sev.GetAllList().FirstOrDefault(a=>a.Id==Id);
        }


        #region 类别方法

        /// <summary>
        /// 新增类别方法
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddNewCategory(Models.ys_JobCategory model)
        {
           return sev.AddNewCategory(model);
        }

        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool ModifyCategory(Models.ys_JobCategory model)
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
        public Models.ys_JobCategory GetOneCategoryById(Guid CategoryId)
        {
            return sev.GetAllListCategory().FirstOrDefault(a=>a.Id==CategoryId);
        }

        /// <summary>
        /// 获取所有的类别列表
        /// </summary>
        /// <returns></returns>
        public List<Models.ys_JobCategory> GetAllListCategory()
        {
            return sev.GetAllListCategory().Where(a => a.IsRemoved == false).ToList();
        }
        #endregion

        /// <summary>
        /// 获取机构信息
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable GetDtBranch()
        {
           return sev.GetDtBranch();
        }


    }
}
