using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace RightingSys.DAL
{
    public  class FingerPrintService
    {

        public bool AddNew(Models.ACL_FingerPrint model)
        {
            SqlParameter[] Param = new SqlParameter[]{
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@UserId",model.UserId),
                new SqlParameter("@FingerData",model.FingerData),
                new SqlParameter("@FingerDescription",model.FingerDescription),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved)
            };

            return Models.SqlHelper.ExecuteNoQuery(@"INSERT INTO [dbo].[ACL_FingerPrint]
           ([Id]
           ,[UserId]
           ,[FingerData]
           ,[FingerDescription]
           ,[CreateTime]
           ,[IsRemoved])
     VALUES
           (@Id
           ,@UserId
           ,@FingerData
           ,@FingerDescription
           ,@CreateTime
           ,@IsRemoved)", Param) > 0 ? true : false;
        }

        public bool Modify(Models.ACL_FingerPrint model)
        {
            SqlParameter[] Param = new SqlParameter[]{
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@UserId",model.UserId),
                new SqlParameter("@FingerData",model.FingerData),
                new SqlParameter("@FingerDescription",model.FingerDescription),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved)
            };


            return Models.SqlHelper.ExecuteNoQuery(@"UPDATE [dbo].[ACL_FingerPrint]
            SET [Id] = @Id
                ,[UserId] = @UserId
                ,[FingerData] = @FingerData
                ,[FingerDescription] = @FingerDescription
                ,[CreateTime] = @CreateTime
                ,[IsRemoved] = @IsRemoved
                WHERE [Id] = @Id", Param) > 0 ? true : false;
        }

        public bool Delete(Guid UserId)
        {
            string sqlText = string.Format("Delete ACL_FingerPrint where UserId='{0}'", UserId);
            return Models.SqlHelper.ExecuteNoQuery(sqlText) > 0 ? true : false;
        }

        public bool ExistsById(Guid Id)
        {
            string sqlText = string.Format("select count(Id) from ACL_FingerPrint where Id='{0}' ",Id);
            return Models.SqlHelper.ExecuteScalar(sqlText).ToString() == "0" ? false : true;
        }
        public IList<Models.ACL_FingerPrint> GetAllList()
        {
            List<Models.ACL_FingerPrint> list = new List<Models.ACL_FingerPrint>();

            string sqlText = "select a.*,b.FullName from ACL_FingerPrint as a inner join ACL_User as b on a.UserId=b.Id where a.IsRemoved=0 ";
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            list = Models.SqlHelper.DataTableToList<Models.ACL_FingerPrint>(dt).ToList();
            return list;
        }

        public Models.ACL_FingerPrint GetOneById(Guid Id)
        {
            List<Models.ACL_FingerPrint> list = new List<Models.ACL_FingerPrint>();

            string sqlText = string.Format("select a.*,b.FullName from ACL_FingerPrint as a inner join ACL_User as b on a.UserId=b.Id where a.IsRemoved=0  and a.Id='{0}'", Id);
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            list = Models.SqlHelper.DataTableToList<Models.ACL_FingerPrint>(dt).ToList();
            return list[0];
        }
    }
}
