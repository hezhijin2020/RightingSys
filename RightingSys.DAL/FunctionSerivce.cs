using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RightingSys.DAL
{
    public class FunctionSerivce
    {
        public bool AddNew(Models.ACL_Function model)
        {
            string sqlText = @"INSERT INTO [dbo].[ACL_Function]
                           ([Id]
                           ,[FuncName]
                           ,[FuncHandle]
                           ,[SystemId]
                           ,[SortCode]
                           ,[ParentId]
                           ,[CreateTime]
                           ,[IsRemoved])
                        values
                           (@Id
                           ,@FuncName
                           ,@FuncHandle
                           ,@SystemId
                           ,@SortCode
                           ,@ParentId
                           ,@CreateTime
                           ,@IsRemoved)";

            SqlParameter s1 = new SqlParameter("@Id", model.Id);
            SqlParameter s2 = new SqlParameter("@FuncName", model.FuncName);
            SqlParameter s3 = new SqlParameter("@FuncHandle", model.FuncHandle);
            SqlParameter s4 = new SqlParameter("@SystemId", model.SystemId);
            SqlParameter s5 = new SqlParameter("@SortCode", model.SortCode);
            SqlParameter s6 = new SqlParameter("@ParentId", model.ParentId);
            SqlParameter s7 = new SqlParameter("@CreateTime", model.CreateTime);
            SqlParameter s8 = new SqlParameter("@IsRemoved", model.IsRemoved);

            SqlParameter[] cmdPara = new SqlParameter[] { s1, s2, s3, s4, s5, s6, s7, s8};
            return Models.SqlHelper.ExecuteNoQuery(sqlText, cmdPara) > 0 ? true : false;

        }
        public bool Modify(Models.ACL_Function model)
        {
            string sqlText = @"UPDATE [dbo].[ACL_Function]
                               SET [FuncName] = @FuncName
                                  ,[FuncHandle] = @FuncHandle
                                  ,[SystemId] = @SystemId
                                  ,[SortCode] = @SortCode
                                  ,[ParentId] = @ParentId
                                  ,[CreateTime] = @CreateTime
                                  ,[IsRemoved] = @IsRemoved
                             WHERE [Id] = @Id";

            SqlParameter s1 = new SqlParameter("@Id", model.Id);
            SqlParameter s2 = new SqlParameter("@FuncName", model.FuncName);
            SqlParameter s3 = new SqlParameter("@FuncHandle", model.FuncHandle);
            SqlParameter s4 = new SqlParameter("@SystemId", model.SystemId);
            SqlParameter s5 = new SqlParameter("@SortCode", model.SortCode);
            SqlParameter s6 = new SqlParameter("@ParentId", model.ParentId);
            SqlParameter s7 = new SqlParameter("@CreateTime", model.CreateTime);
            SqlParameter s8 = new SqlParameter("@IsRemoved", model.IsRemoved);

            SqlParameter[] cmdPara = new SqlParameter[] { s1, s2, s3, s4, s5, s6, s7, s8 };
            return Models.SqlHelper.ExecuteNoQuery(sqlText, cmdPara) > 0 ? true : false;
        }

        public bool Delete(Guid Id)
        {
            string sqlText = @"UPDATE[dbo].[ACL_Function] SET [IsRemoved] = 1 WHERE[Id] = @Id";

            SqlParameter s1 = new SqlParameter("@Id", Id);
            SqlParameter[] cmdPara = new SqlParameter[] { s1};

           return  Models.SqlHelper.ExecuteNoQuery(sqlText, cmdPara) > 0 ? true : false;
         
        }

        public bool ExistsRoleById(Guid Id)
        {
            string sqlText = " select COUNT(Id) FROM [ACL_Role_Function] where [FunctionId]=@Id";
            SqlParameter s1 = new SqlParameter("@Id", Id);
            return Models.SqlHelper.ExecuteNoQuery(sqlText, s1) > 0 ? true : false;
        }

     
        public IList<Models.ACL_Function> GetAllList()
        {
            string sqlText = @"SELECT [Id]
                              ,[FuncName]
                              ,[FuncHandle]
                              ,[SystemId]
                              ,[SortCode]
                              ,[ParentId]
                              ,[CreateTime]
                              ,[IsRemoved]
                          FROM [dbo].[ACL_Function] Where IsRemoved=0";
             System.Data.DataTable dt= Models.SqlHelper.ExecuteDataTable(sqlText);
             return  Models.SqlHelper.DataTableToList<Models.ACL_Function>(dt);
        }

        public System.Data.DataTable GetTbFunctionTree()
        {
            string sqlText = @"select Id, ParentId,FuncName, [FuncHandle],[SortCode], 0 TypeID,SystemId from ACL_Function WHERE IsRemoved=0
                               union   select Id,null,SystemName,0,'',1,Id from ACL_System  WHERE IsRemoved=0  order by sortcode";
            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }

        public System.Data.DataTable GetFuncHandleList()
        {
            string sqlText = "SELECT[ID] ,[Name] ,[Code] ,[HandleNo] FROM[dbo].[ACL_FuncHandle] order by HandleNo";
            
            return Models.SqlHelper.ExecuteDataTable(sqlText);

        }
    }
}
