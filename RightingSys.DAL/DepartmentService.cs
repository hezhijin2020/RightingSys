using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace RightingSys.DAL
{
    public class DepartmentService 
    {

        public bool AddNew(Models.ACL_Department model)
        {
            SqlParameter[] Param = new SqlParameter[] {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@DepartmentName",model.DepartmentName),
                new SqlParameter("@SimpleCode",model.SimpleCode),
                new SqlParameter("@SortCode",model.SortCode),
                new SqlParameter("@ParentId",model.ParentId),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved)
            };

            return Models.SqlHelper.ExecuteNoQuery(@"INSERT INTO [dbo].[ACL_Department]
           ([Id]
           ,[DepartmentName]
           ,[SimpleCode]
           ,[SortCode]
           ,[ParentId]
           ,[CreateTime]
           ,[IsRemoved])
     VALUES
           (@Id
           ,@DepartmentName
           ,@SimpleCode
           ,@SortCode
           ,@ParentId
           ,@CreateTime
           ,@IsRemoved)", Param) > 0 ? true : false;
        }

        public bool Modify(Models.ACL_Department model)
        {
            SqlParameter[] Param = new SqlParameter[] {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@DepartmentName",model.DepartmentName),
                new SqlParameter("@SimpleCode",model.SimpleCode),
                new SqlParameter("@SortCode",model.SortCode),
                new SqlParameter("@ParentId",model.ParentId),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved)
                    };


            return Models.SqlHelper.ExecuteNoQuery(@"UPDATE [dbo].[ACL_Department]
                SET  [DepartmentName] = @DepartmentName
                    ,[SimpleCode] = @SimpleCode
                    ,[SortCode] = @SortCode
                    ,[ParentId] = @ParentId
                    ,[CreateTime] = @CreateTime
                    ,[IsRemoved] = @IsRemoved
                WHERE [Id] = @Id", Param) > 0 ? true : false;
        }

        public bool Delete(Guid Id)
        {
            string sqlText = string.Format("Delete ACL_Department where Id='{0}'", Id);
            return Models.SqlHelper.ExecuteNoQuery(sqlText) > 0 ? true : false;
        }

        public bool ExistsUserById(Guid Id)
        {
            string sqlText = @"select COUNT([Id])from ACL_User where DepartmentId=@Id";
            SqlParameter s1 = new SqlParameter("@Id", Id);
            return Models.SqlHelper.ExecuteNoQuery(sqlText, s1)>0?true:false;
        }
        public bool ExistsById(Guid Id)
        {
            string sqlText = "select count(Id) from ACL_Department where Id='{0}' ";
            return Models.SqlHelper.ExecuteScalar(sqlText).ToString() == "0" ? false : true;
        }

        public bool ExistsByName(Guid Id)
        {
            string sqlText = "select count(Id) from ACL_Department where  DepartmentName ='{0}' ";
            return Models.SqlHelper.ExecuteScalar(sqlText).ToString() == "0" ? false : true;
        }

        public IList<Models.ACL_Department> GetAllList()
        {
            List<Models.ACL_Department> list = new List<Models.ACL_Department>();

            string sqlText = "select * from ACL_Department where IsRemoved=0 ";
            System.Data.DataTable dt= Models.SqlHelper.ExecuteDataTable(sqlText);
            list = Models.SqlHelper.DataTableToList<Models.ACL_Department>(dt).ToList();
            return list;
        }

       public  Models.ACL_Department GetOneById(Guid Id)
        {
            List<Models.ACL_Department> list = new List<Models.ACL_Department>();

            string sqlText = string.Format("select * from ACL_Department where Id='{0}'", Id);
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            list = Models.SqlHelper.DataTableToList<Models.ACL_Department>(dt).ToList();
            return list[0];
        }
    }
}