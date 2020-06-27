using System;
using System.Data;

namespace RightingSys.BLL
{
    public class WorkPlanManager
    {
        DAL.WorkPlanService sev = new DAL.WorkPlanService();

        /// <summary>
        /// 获取所有记录
        /// </summary>
        /// <param name="sqlText">sql语句</param>
        /// <returns></returns>
        public DataTable GetDtWorkPlan(string sqlText)
        {
            return sev.GetDtWorkPlan(sqlText);
        }



        /// <summary>
        /// 保存信息
        /// </summary>
        /// <param name="md">实体</param>
        /// <param name="FiledName">字段</param>
        /// <returns></returns>
        public bool Save(Models.ys_WorkPlan md, string FiledName)
        {
            return sev.Save(md, FiledName);
        }
    }
}
