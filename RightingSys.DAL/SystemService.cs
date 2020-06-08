using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RightingSys.DAL
{
    public class SystemService
    {
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
       
        public bool Delete(Guid Id)
        {
            string sqlText = string.Format(@"Update  [dbo].[ACL_System] set IsRemoved=1 WHERE Id='{0}'", Id);
            return Models.SqlHelper.ExecuteNoQuery(sqlText) > 0 ? true : false;
        }
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
        public bool ExistsByName(string systemName)
        {
            string sqlText = string.Format("SELECT Count(Id) FROM [dbo].[ACL_System] where [SystemName]='{0}'", systemName);
            return (int)Models.SqlHelper.ExecuteScalar(sqlText) > 0 ? true : false;
        }

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
