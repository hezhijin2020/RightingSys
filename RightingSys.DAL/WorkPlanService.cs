using System;
using System.Data;

namespace RightingSys.DAL
{
    public class WorkPlanService
    {
        /// <summary>
        /// 获取所有记录
        /// </summary>
        /// <param name="sqlText">sql语句</param>
        /// <returns></returns>
        public DataTable GetDtWorkPlan(string sqlText)
        {
            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }

        /// <summary>
        /// 检查记录是否存在
        /// </summary>
        /// <param name="StaffId">职员</param>
        /// <param name="WorkDay">日期</param>
        /// <returns></returns>
        private bool ExistsByStaffAndDay(Guid StaffId, DateTime WorkDay)
        {
            string sqlText = string.Format("select Count(Id) from ys_WorkPlan where StaffId='{0}' and WorkDay='{1}'", StaffId, WorkDay);
            return Convert.ToInt32(Models.SqlHelper.ExecuteScalar(sqlText))>0;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model">实体</param>
        /// <param name="FiledName">字段</param>
        /// <returns></returns>

        public bool Modify(Models.ys_WorkPlan model, string FiledName)
        {
            string FiledValue = "";
            if (FiledName == "CheckPlan")
            {
                FiledValue = model.CheckPlan;
            }
            else if (FiledName == "WorkPlan")
            {
                FiledValue = model.WorkPlan;
            }
            else if (FiledName == "FocusWork")
            {
                FiledValue = model.FocusWork;
            }
            else
            {
                return false;
            }

            string sqlText = string.Format(@"UPDATE [RightingSys].[dbo].[ys_WorkPlan]
              SET [{0}] = '{1}'
                 ,[OperatorId] = '{2}'
                 ,[OperatorName] = '{3}'
                 ,[CreateTime] = getdate()
            WHERE [WorkDay] = '{4}' and [StaffId] = '{5}'", FiledName,FiledValue, model.OperatorId, model.OperatorName, model.WorkDay, model.StaffId);

            return Models.SqlHelper.ExecuteNoQuery(sqlText) > 0;
        }

        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model">实体</param>
        /// <param name="FiledName">字段</param>
        /// <returns></returns>
        private bool AddNew(Models.ys_WorkPlan model,string FiledName)
        {
            string FiledValue = "";
            if (FiledName == "CheckPlan")
            {
                FiledValue = model.CheckPlan;
            }
            else if (FiledName == "WorkPlan")
            {
                FiledValue = model.WorkPlan;
            }
            else if (FiledName == "FocusWork")
            {
                FiledValue = model.FocusWork;
            }
            else
            {
                return false;
            }

            string sqlText =string.Format( @"INSERT INTO [RightingSys].[dbo].[ys_WorkPlan]
           ([{0}]
           ,[WorkDay]
           ,[StaffId]
           ,[StaffName]
           ,[OperatorId]
           ,[OperatorName])
     VALUES
           ('{1}'
           ,'{2}'
           ,'{3}'
           ,'{4}'
           ,'{5}'
           ,'{6}')",FiledName,FiledValue,model.WorkDay,model.StaffId,model.StaffName,model.OperatorId,model.OperatorName);

            return Models.SqlHelper.ExecuteNoQuery(sqlText) > 0;
        }

        /// <summary>
        /// 保存信息
        /// </summary>
        /// <param name="md">实体</param>
        /// <param name="FiledName">字段</param>
        /// <returns></returns>
        public bool Save(Models.ys_WorkPlan md,string FiledName)
        {
            if (ExistsByStaffAndDay(md.StaffId, md.WorkDay))
            {
                return this.Modify(md, FiledName);
            }
            else
            {
                return this.AddNew(md, FiledName);
            }
        }
    }
}
