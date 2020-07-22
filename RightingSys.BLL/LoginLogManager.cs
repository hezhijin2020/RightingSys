using System;
using System.Collections.Generic;
using System.Linq;
namespace RightingSys.BLL
{
    public class LoginLogManager
    {
        DAL.LoginLogService Sev = new DAL.LoginLogService();
        /// <summary>
        /// 获取登录记录
        /// </summary>
        /// <returns></returns>
        public List<Models.ACL_LoginLog> GetAllList()
        {
            return Sev.GetAllList().Where(a => a.IsRemoved == false).ToList();
        }

        /// <summary>
        /// 有条件的筛选登录日志
        /// </summary>
        /// <param name="SystemId">系统ID</param>
        /// <param name="UserId">用户Id</param>
        /// <param name="startDay">开始日期</param>
        /// <param name="endDay">结束日期</param>
        /// <returns></returns>
        public List<Models.ACL_LoginLog> GetList(Guid systemId,Guid userId,DateTime startDay,DateTime endDay)
        {
            //只有日期 
            if (systemId ==Guid.Empty && userId ==Guid.Empty && startDay != null & endDay != null)
            {
                return Sev.GetAllList().Where(a => a.IsRemoved == false 
                && a.CreateTime>=startDay
                && a.CreateTime <= endDay).ToList();
            }//有用户
            else if (systemId == Guid.Empty && userId != Guid.Empty && startDay != null & endDay != null)
            {
                return Sev.GetAllList().Where(a =>
                a.IsRemoved == false
                && a.CreateTime >= startDay 
                && a.CreateTime <= endDay
                && a.UserId==userId).ToList();
            }//有用户有系统
            else if (systemId != Guid.Empty && userId != Guid.Empty && startDay != null & endDay != null)
            {
                return Sev.GetAllList().Where(a => 
                a.IsRemoved == false 
                && a.CreateTime >= startDay
                && a.CreateTime <= endDay
                && a.UserId==userId
                && a.SystemId==systemId).ToList();
            }//只有系统
            else if (systemId != Guid.Empty && userId == Guid.Empty && startDay != null & endDay != null)
            {
                return Sev.GetAllList().Where(a => 
                a.IsRemoved == false 
                && a.CreateTime >= startDay
                && a.CreateTime <= endDay
                && a.SystemId==systemId).ToList();
            }
            return null;
        }

        /// <summary>
        /// 获取分页数据
        /// </summary>
        /// <param name="systemId"></param>
        /// <param name="userId"></param>
        /// <param name="startDay"></param>
        /// <param name="endDay"></param>
        /// <param name="pageSize">每页记录数</param>
        /// <param name="PageNum">第多少页</param>
        /// <returns></returns>
        public List<Models.ACL_LoginLog> GetListByPage(Guid systemId, Guid userId, DateTime startDay, DateTime endDay, int pageSize, int PageNum)
        {
            return GetList(systemId, userId, startDay, endDay).Skip(pageSize*(PageNum-1)).Take(pageSize).ToList();
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <returns></returns>
        public bool DeleteByDayNum(int dayNum)
        {
            string where = string.Format("WHERE CreateTime<'{0}'", System.DateTime.Now.Date.AddDays(dayNum));
            return Sev.Delete(where);
        }
    }
}
