using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RightingSys.DAL
{
    public class OperationLogService
    {
        /// <summary>
        /// 获取操作日志信息
        /// </summary>
        /// <returns></returns>
        public IList<Models.ACL_OperationLog> GetAllList()
        {
            string sqlText = @"SELECT [Id]
                                 ,[LogName]
                                 ,[UserId]
                                 ,[LoginName]
                                 ,[FullName]
                                 ,[DepartmentName]
                                 ,[DepartmentId]
                                 ,[LoginIP]
                                 ,[LoginMac]
                                 ,[SystemId]
                                 ,[SystemName]
                                 ,[OperationType]
                                 ,[SqlCommand]
                                 ,[OperationTable]
                                 ,[CreateTime]
                                 ,[IsRemoved]
                             FROM [RightingSys].[dbo].[ACL_OperationLog]";

            DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            IList<Models.ACL_OperationLog> list = Models.SqlHelper.DataTableToList<Models.ACL_OperationLog>(dt);
            return list;

            //clsPublic.appLogs.Add_OperationLog("操作记录查询",DateTime.Now,"ACL_OperationLog","查询",sql);
        }

    }
}
