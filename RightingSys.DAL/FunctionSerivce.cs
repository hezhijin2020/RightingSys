using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace RightingSys.DAL
{
    public class FunctionSerivce
    {
        /// <summary>
        /// 功能新增方法
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
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

        /// <summary>
        /// 功能修改方法
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
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

        /// <summary>
        /// 删除功能方法
        /// </summary>
        /// <param name="Id">功能Id</param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            string sqlText = @"UPDATE[dbo].[ACL_Function] SET [IsRemoved] = 1 WHERE[Id] = @Id";

            SqlParameter s1 = new SqlParameter("@Id", Id);
            SqlParameter[] cmdPara = new SqlParameter[] { s1};
           return  Models.SqlHelper.ExecuteNoQuery(sqlText, cmdPara) > 0 ? true : false;
         
        }

        /// <summary>
        /// 检查角色是否有功能权限
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool ExistsRoleById(Guid Id)
        {
            string sqlText = " select COUNT(Id) FROM [ACL_Role_Function] where [FunctionId]=@Id";
            SqlParameter s1 = new SqlParameter("@Id", Id);
            return Models.SqlHelper.ExecuteNoQuery(sqlText, s1) > 0 ? true : false;
        }

        /// <summary>
        /// 获取所有功能列表
        /// </summary>
        /// <returns></returns>
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
                          FROM [dbo].[ACL_Function]";
             System.Data.DataTable dt= Models.SqlHelper.ExecuteDataTable(sqlText);
             return  Models.SqlHelper.DataTableToList<Models.ACL_Function>(dt);
        }

        /// <summary>
        /// 获取权限树列表
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable GetTbFunctionTree()
        {
            string sqlText = @"select Id, ParentId,FuncName, [FuncHandle],[SortCode], 0 TypeID,SystemId from ACL_Function WHERE IsRemoved=0 and SystemId in(select Id from ACL_System  WHERE IsRemoved=0 )
                       union   select Id,null,SystemName,0,'',1,Id from ACL_System  WHERE IsRemoved=0  order by sortcode";
            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }

       /// <summary>
       /// 获取功能菜单列表
       /// </summary>
       /// <returns></returns>
        public System.Data.DataTable GetFuncHandleList()
        {
            string sqlText = "SELECT[ID] ,[Name] ,[Code] ,[HandleNo] FROM[dbo].[ACL_FuncHandle] order by HandleNo";
            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }

        /// <summary>
        /// 获取所指定功能的所有引用角色列表
        /// </summary>
        /// <param name="Id">功能Id</param>
        /// <returns></returns>
        public IList<Models.ACL_Role> GetRoleListByFuncId(Guid FuncId)
        {
            string sqlText =string.Format( @"SELECT distinct b.*
                               FROM [ACL_Role_Function] as a inner join [ACL_Role] as b on a.RoleId=b.Id
                               where  a.IsRemoved=0 and b.IsRemoved=0 and a.FunctionId='{0}'", FuncId);
            System.Data.DataTable dt= Models.SqlHelper.ExecuteDataTable(sqlText);

            return Models.SqlHelper.DataTableToList<Models.ACL_Role>(dt);
        }
    }
}
