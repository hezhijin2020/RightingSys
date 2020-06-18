using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RightingSys.DAL
{
    /// <summary>
    /// 系统服务类
    /// </summary>
    public class SystemService
    {
        /// <summary>
        /// 新增系统授权
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(Models.ACL_System model)
        {

            SqlParameter[] cmdParam = new SqlParameter[]{
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@SystemName",model.SystemName),
                new SqlParameter("@SimpleCode",model.SimpleCode),
                new SqlParameter("@SortCode",model.SortCode),
                new SqlParameter("@SystemDescription",model.SystemDescription)};

            string sqlText = @"INSERT INTO [RightingSys].[dbo].[ACL_System]
                               ([Id]
                               ,[SystemName]
                               ,[SimpleCode]
                               ,[SortCode]
                               ,[SystemDescription])
                         VALUES(@Id
                               ,@SystemName
                               ,@SimpleCode
                               ,@SortCode
                               ,@SystemDescription)";
            return Models.SqlHelper.ExecuteNoQuery(sqlText, cmdParam) > 0 ? true : false;
        }

        /// <summary>
        /// 修改系统信息
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool Modify(Models.ACL_System model)
        {
            SqlParameter[] cmdParam = new SqlParameter[]{
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@SystemName",model.SystemName),
                new SqlParameter("@SimpleCode",model.SimpleCode),
                new SqlParameter("@SortCode",model.SortCode),
                new SqlParameter("@SystemDescription",model.SystemDescription)};

            string sqlText = @"UPDATE [RightingSys].[dbo].[ACL_System]
                                                SET [SystemName] = @SystemName
                                                    ,[SimpleCode] = @SimpleCode
                                                    ,[SortCode] = @SortCode
                                                    ,[SystemDescription] = @SystemDescription
                                                WHERE [Id] = @Id";

            return Models.SqlHelper.ExecuteNoQuery(sqlText, cmdParam) > 0 ? true : false;

        }
       
        /// <summary>
        /// 删除系统信息（伪删除），系统下的所有功能也伪删除
        /// </summary>
        /// <param name="Id">系统ID</param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            Dictionary<SqlParameter[], string> dicCmd = new Dictionary<SqlParameter[], string>();
            string sqlText = string.Format(@"Update  [dbo].[ACL_System] set IsRemoved=1 WHERE Id='{0}'", Id);
            string sqlText1= string.Format(@"Update  [dbo].[ACL_Function] set IsRemoved=1 WHERE [SystemId]='{0}'", Id);
            
            dicCmd.Add(null, sqlText);
            dicCmd.Add(null, sqlText1);

            return Models.SqlHelper.ExecuteTransaction1(dicCmd) > 0 ? true : false;
        }

        /// <summary>
        /// 获取所有系统
        /// </summary>
        /// <returns></returns>

        public IList<Models.ACL_System> GetAllSystems()
        {
            string sqlText = @"SELECT  [Id]
                                      ,[SystemName]
                                      ,[SimpleCode]
                                      ,[SortCode]
                                      ,[SystemDescription]
                                      ,[URL]
                                      ,[Version]
                                      ,[LastTime]
                                      ,[CreateTime]
                                      ,[IsRemoved]
                                  FROM [RightingSys].[dbo].[ACL_System]";

            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            return Models.SqlHelper.DataTableToList<Models.ACL_System>(dt);
        }

        /// <summary>
        /// 检查系统名称是否存在
        /// </summary>
        /// <param name="systemName">名称</param>
        /// <returns></returns>
        public bool ExistsByName(string systemName)
        {
            string sqlText = string.Format("SELECT Count(Id) FROM [dbo].[ACL_System] where [SystemName]='{0}'", systemName);
            return (int)Models.SqlHelper.ExecuteScalar(sqlText) > 0 ? true : false;
        }

       /// <summary>
       /// 修改系统版本
       /// </summary>
       /// <param name="model">实体</param>
       /// <returns></returns>

        public bool ModifyVersion(Models.ACL_System model)
        {
            SqlParameter[] cmdParam = new SqlParameter[]{
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@URL",model.URL),
                new SqlParameter("@Version",model.Version),
                new SqlParameter("@LastTime",model.LastTime) };

            string sqlText = @"UPDATE [RightingSys].[dbo].[ACL_System]
                                                SET [URL] = @URL
                                                    ,[Version] = @Version
                                                    ,[LastTime] = @LastTime
                                                WHERE [Id] = @Id";

            return Models.SqlHelper.ExecuteNoQuery(sqlText, cmdParam) > 0 ? true : false;

        }

    }
}
