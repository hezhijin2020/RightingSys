using System.Collections.Generic;
using System.Linq;
namespace RightingSys.DAL
{
    public class LoginLogService
    {
        /// <summary>
        /// 获取登录记录
        /// </summary>
        /// <returns></returns>
        public IList<Models.ACL_LoginLog> GetAllList()
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
                                     ,[CreateTime]
                                     ,[IsRemoved]
                                 FROM [RightingSys].[dbo].[ACL_LoginLog]";

            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            return Models.SqlHelper.DataTableToList<Models.ACL_LoginLog>(dt).ToList() ;
        }

        /// <summary>
        /// 删除记录
        /// </summary>
        /// <returns></returns>
        public bool Delete(string where)
        {
            string sqlText = string.Format(" DELETE FROM [RightingSys].[dbo].[ACL_LoginLog] {0} ",where);

            return Models.SqlHelper.ExecuteNoQuery(sqlText)>0;
            //appLogs.Add_OperationLog("登录记录删除", DateTime.Now, "ACL_LoginLog", "删除", sqlText);
        }
    }
}
