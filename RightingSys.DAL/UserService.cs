using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace RightingSys.DAL
{
    public class UserService
    {
        public bool AddNew(Models.ACL_User model)
        {
            SqlParameter[] Param = new SqlParameter[] {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@LoginName",model.LoginName),
                new SqlParameter("@LoginPwd",model.LoginPwd),
                new SqlParameter("@DepartmentId",model.DepartmentId),
                new SqlParameter("@SimpleCode",model.SimpleCode),
                new SqlParameter("@FullName",model.FullName),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved)
            };

            return Models.SqlHelper.ExecuteNoQuery(@"INSERT INTO [dbo].[ACL_User]
           ([Id]
           ,[LoginName]
           ,[LoginPwd]
           ,[DepartmentId]
           ,[SimpleCode]
           ,[FullName]
           ,[CreateTime]
           ,[IsRemoved])
     VALUES
           (@Id
           ,@LoginName
           ,@LoginPwd
           ,@DepartmentId
           ,@SimpleCode
           ,@FullName
           ,@CreateTime
           ,@IsRemoved)", Param) > 0 ? true : false;
        }

        public bool Modify(Models.ACL_User model)
        {
            SqlParameter[] Param = new SqlParameter[] {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@LoginName",model.LoginName),
                new SqlParameter("@LoginPwd",model.LoginPwd),
                new SqlParameter("@DepartmentId",model.DepartmentId),
                new SqlParameter("@SimpleCode",model.SimpleCode),
                new SqlParameter("@FullName",model.FullName),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved)
            };


            return Models.SqlHelper.ExecuteNoQuery(@"UPDATE [dbo].[ACL_User]
                SET  [LoginName] = @LoginName
                    ,[LoginPwd] = @LoginPwd
                    ,[DepartmentId] = @DepartmentId
                    ,[SimpleCode] = @SimpleCode
                    ,[FullName] = @FullName
                    ,[CreateTime] = @CreateTime
                    ,[IsRemoved] = @IsRemoved
                WHERE [Id] = @Id", Param) > 0 ? true : false;
        }

        public bool Delete(Guid Id)
        {
            string sqlText = string.Format("Delete ACL_User where Id='{0}'", Id);
            return Models.SqlHelper.ExecuteNoQuery(sqlText) > 0 ? true : false;
        }

        public bool ExistsById(Guid Id)
        {
            string sqlText = "select count(Id) from ACL_User where Id='{0}' ";
            return Models.SqlHelper.ExecuteScalar(sqlText).ToString() == "0" ? false : true;
        }

        public bool ExistsByName(string Name)
        {
            string sqlText =string.Format( "select count(Id) from ACL_User where LoginName='{0}' ",Name);
            return Models.SqlHelper.ExecuteScalar(sqlText).ToString() == "0" ? false : true;
        }

        public IList<Models.ACL_User> GetAllList()
        {
            List<Models.ACL_User> list = new List<Models.ACL_User>();

            string sqlText = @"select a.*,b.DepartmentName
from ACL_User as a left join ACL_Department as b on a.DepartmentId = b.Id
where a.IsRemoved = 0 ";
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            list = Models.SqlHelper.DataTableToList<Models.ACL_User>(dt).ToList();
            return list;
        }

        public Models.ACL_User GetOneById(Guid Id)
        {
            List<Models.ACL_User> list = new List<Models.ACL_User>();

            string sqlText = string.Format("select * from ACL_User where Id='{0}'", Id);
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            list = Models.SqlHelper.DataTableToList<Models.ACL_User>(dt).ToList();
            return list[0];
        }
    }
}
