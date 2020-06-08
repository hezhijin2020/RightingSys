using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RightingSys.DAL
{
    public class RoleService
    {
        #region 角色操作
        public bool AddNew(Models.ACL_Role model)
        {
            string sqlText = @"INSERT INTO [dbo].[ACL_Role]
           ([Id]
           ,[RoleName]
           ,[SimpleCode]
           ,[SortCode]
           ,[ParentId]
           ,[CreateTime]
           ,[IsRemoved])
     VALUES
           (@Id
           ,@RoleName
           ,@SimpleCode
           ,@SortCode
           ,@ParentId
           ,@CreateTime
           ,@IsRemoved)";

            SqlParameter s1 = new SqlParameter("@Id", model.Id);
            SqlParameter s2 = new SqlParameter("@ParentId", model.ParentId);
            SqlParameter s3 = new SqlParameter("@SimpleCode", model.SimpleCode);
            SqlParameter s4 = new SqlParameter("@RoleName", model.RoleName);
            SqlParameter s5 = new SqlParameter("@SortCode", model.SortCode);
            SqlParameter s6 = new SqlParameter("@CreateTime", model.CreateTime);
            SqlParameter s7 = new SqlParameter("@IsRemoved", model.IsRemoved);
            SqlParameter[] cmdParm = new SqlParameter[] { s1, s2, s3, s4, s5, s6, s7 };

            return Models.SqlHelper.ExecuteNoQuery(sqlText, cmdParm)>0 ?true : false;
        }
        public bool Modify(Models.ACL_Role model)
        {
            string sqlText = @"UPDATE [dbo].[ACL_Role]
                                   SET [RoleName] = @RoleName
                                      ,[SimpleCode] = @SimpleCode
                                      ,[SortCode] = @SortCode
                                      ,[ParentId] = @ParentId
                                      ,[CreateTime] = @CreateTime
                                      ,[IsRemoved] = @IsRemoved
                                 WHERE [Id] = @Id";
            SqlParameter s1 = new SqlParameter("@Id", model.Id);
            SqlParameter s2 = new SqlParameter("@ParentId", model.ParentId);
            SqlParameter s3 = new SqlParameter("@SimpleCode", model.SimpleCode);
            SqlParameter s4 = new SqlParameter("@RoleName", model.RoleName);
            SqlParameter s5 = new SqlParameter("@SortCode", model.SortCode);
            SqlParameter s6 = new SqlParameter("@CreateTime", model.CreateTime);
            SqlParameter s7 = new SqlParameter("@IsRemoved", model.IsRemoved);
            SqlParameter[] cmdParm = new SqlParameter[] { s1, s2, s3, s4, s5, s6, s7 };

            return Models.SqlHelper.ExecuteNoQuery(sqlText, cmdParm) > 0 ? true : false;
        }
        public bool Delete(Guid Id)
        {
            string sqlText = @"UPDATE[dbo].[ACL_Role] SET IsRemoved=1 where Id=@Id ";

            SqlParameter s1 = new SqlParameter("@Id", Id);
            SqlParameter[] cmdParm = new SqlParameter[] { s1};

            return Models.SqlHelper.ExecuteNoQuery(sqlText, cmdParm) > 0 ? true : false;
        }

        public bool ExistsRoleByName(string RoleName)
        {
            string sqlText = " SELECT COUNT([Id]) FROM[dbo].[ACL_Role] WHERE RoleName=@RoleName";
            SqlParameter s1 = new SqlParameter("@RoleName", RoleName);
            return Models.SqlHelper.ExecuteNoQuery(sqlText, s1) > 0 ? true : false;
        }
        public bool ExistsUserById(Guid Id)
        {
            string sqlText = " SELECT COUNT([Id]) FROM[dbo].[ACL_Role_User] WHERE RoleId=@Id";
            SqlParameter s1 = new SqlParameter("@Id", Id);
            return Models.SqlHelper.ExecuteNoQuery(sqlText, s1) > 0 ? true : false;

        }
        public bool ExistsDepartmentById(Guid Id)
        {
            string sqlText = " SELECT COUNT([Id]) FROM[dbo].[ACL_Role_Department] WHERE RoleId=@Id";
            SqlParameter s1 = new SqlParameter("@Id", Id);
            return Models.SqlHelper.ExecuteNoQuery(sqlText, s1) > 0 ? true : false;

        }
        public IList<Models.ACL_Role> GetAllList()
        {
            string sqlText = @" SELECT  * FROM [dbo].[ACL_Role] Where IsRemoved=0 ";
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            return Models.SqlHelper.DataTableToList<Models.ACL_Role>(dt);
        }

        public Models.ACL_Role GetOneById(Guid Id)
        {
            string sqlText = @" SELECT  * FROM [dbo].[ACL_Role] Where IsRemoved=0 ";
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            return Models.SqlHelper.DataTableToList<Models.ACL_Role>(dt).FirstOrDefault(s=>s.Id==Id);
        }
        #endregion

        #region 角色授权
        public System.Data.DataTable GetTbAllFunctionByRoleId(Guid RoleId)
        {
            string sqlText = string.Format(@"select a.Id,a.ParentId,a.FuncName,a.FuncHandle,a.SortCode,a.TypeId ,isnull(b.OpCode,0) OpCode,ISNULL( b.[Enabled],0) [Enabled] from  (
            select Id,ParentId,FuncName, FuncHandle,SortCode, 1 TypeId from ACL_Function WHERE IsRemoved=0
      union select Id,null,  SystemName,          0,       '',0 TypeId from ACL_System  WHERE IsRemoved=0  ) as a  left join 
				            (select FunctionId,RoleId,OpCode,1 [Enabled] from ACL_Role_Function where RoleId='{0}') as b  on a.ID=b.FunctionId 
            order by SortCode ", RoleId);
            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }

        public System.Data.DataTable GetTbFuncHandlesByHandleNos(string HandleNos)
        {
            string sqlText = string.Format(@"SELECT [Id],[Name],[Code],[HandleNo] FROM [dbo].[ACL_FuncHandle] where HandleNo in({0}) order by HandleNo ", HandleNos);
            return  Models.SqlHelper.ExecuteDataTable(sqlText);
        }

        public bool SaveRighting(System.Data.DataTable dt, string RoleId)
        {
            Dictionary<string, SqlParameter[]> array = new Dictionary<string, SqlParameter[]>();
            array.Add("if   object_id('tempdb..#Right') is not null drop table #tempRoleFunc",null);
            array.Add(" create table #Right (RoleId uniqueidentifier, FuncID uniqueidentifier, OpCode int)",null);
            foreach (System.Data.DataRow r in dt.Rows)
            {
                array.Add(string.Format("insert into #Right values('{0}','{1}',{2})", r["RoleID"], r["FuncID"], r["OpCode"]),null);
            }
            array.Add(string.Format(@"MERGE into ACL_Role_Function as target   using #Right as source on (target.RoleId=source.RoleId and target.FunctionId=source.FuncId ) 
                         when matched and target.OpCode!=source.OpCode then    update set OpCode=source.OpCode
                         when not matched by target and source.RoleId='{0}'  then    insert (RoleId,FunctionId,OpCode)    values(source.RoleId,source.FuncId,source.OpCode)  
                         when not matched by source and target.RoleId='{0}' then    delete    output $action ,inserted.RoleId ,deleted.RoleId,inserted.FunctionId ,deleted.FunctionId;", RoleId),null);
            
            return Models.SqlHelper.ExecuteTransaction(array) > 0 ? true : false;
        }

        #endregion

        #region 用户关联角色       
        public bool AddNewUserByRoleId(Guid RoleId, List<Guid> Users)
        {
            Dictionary<string, SqlParameter[]> SQLCmds = new Dictionary<string, SqlParameter[]>();

            SQLCmds.Add("DELETE [dbo].[ACL_Role_User] WHERE [RoleId]= '" + RoleId + "'", null);

            foreach (Guid Id in Users)
            {
                //SQLCmds.Add("DELETE [dbo].[ACL_Role_User] WHERE [RoleId]= '" + RoleId + "'", null);
                SQLCmds.Add(string.Format("INSERT INTO[dbo].[ACL_Role_User]([Id],[RoleId],[UserId]) VALUES(newid(),'{0}', '{1}')", RoleId, Id), null);
            }

            return Models.SqlHelper.ExecuteTransaction(SQLCmds) > 0 ? true : false;

        }
        public bool DeleteUserByRoleId(Guid RoleId, Guid UserId)
        {
            string sqlText = string.Format("delete [dbo].[ACL_Role_User] where RoleId='{0}'and UserId='{1}'", RoleId, UserId);
            return Models.SqlHelper.ExecuteNoQuery(sqlText) > 0 ? true : false;
        }
        public System.Data.DataTable GetTbAllUsersByRoleId(Guid RoleId)
        {
            string sqlText = string.Format(@"   SELECT  cast( ( CASE WHEN c.RoleId is null THEN 0  ELSE 1 END ) as bit) IsCheck, a.Id,a.FullName,a.LoginName,a.SimpleCode,a.DepartmentId,b.DepartmentName,c.RoleId
             FROM[dbo].ACL_User as a left join ( SELECT * FROM  ACL_Role_User where RoleId='{0}')as c on a.Id=c.UserId 
			     left join ACL_Department as b on a.DepartmentId=b.Id", RoleId);
            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }
        public System.Data.DataTable GetTbUsersByRoleId(Guid RoleId)
        {
            string sqlText = string.Format(@"select a.UserId,a.RoleId,b.FullName 
                    from ACL_Role_User as a left join ACL_User as b on a.UserId=b.Id
					where a.RoleId='{0}'", RoleId);

            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }

        #endregion
        
        #region 机构关联角色
        public bool AddNewDepartmentByRoleId(Guid RoleId, List<string> Departments)
        {
            Dictionary<string, SqlParameter[]> SQLCmds = new Dictionary<string, SqlParameter[]>();

            SQLCmds.Add("DELETE [dbo].[ACL_Role_Department] WHERE [RoleId]= @RoleId",new SqlParameter[] { new SqlParameter("@RoleId", RoleId) });

            foreach (string Id in Departments)
            {
                SQLCmds.Add(string.Format("INSERT INTO[dbo].[ACL_Role_Department]([Id],[RoleId],[DepartmentId]) VALUES(newid(),'{0}', '{1}')", RoleId,Id),null);
            }

           return Models.SqlHelper.ExecuteTransaction(SQLCmds) > 0 ? true : false ;

        }
        public bool DeleteDepartmentByRoleId(Guid RoleId, Guid DepartmentId)
        {
            string sqlText = string.Format("delete [dbo].[ACL_Role_Department] where RoleId='{0}'and DepartmentId='{1}'", RoleId, DepartmentId);
            return Models.SqlHelper.ExecuteNoQuery(sqlText) > 0 ? true : false;
        }
        public System.Data.DataTable GetTbAllDepartmentsByRoleId(Guid RoleId)
        {
            string sqlText = string.Format(@"  SELECT  cast( ( CASE WHEN c.RoleId is null THEN 0  ELSE 1 END ) as bit) IsCheck, a.Id,a.ParentId,a.DepartmentName,a.SimpleCode,a.SortCode,c.RoleId
             FROM[dbo].ACL_Department as a left join ( SELECT * FROM  ACL_Role_Department where RoleId='{0}'   )as c on a.Id=c.DepartmentId ", RoleId);
            // AppPublic.appLogs.Add_OperationLog("查询角色包含机构", DateTime.Now, "ACL_OU", "查询", sqlText);
            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }
        public System.Data.DataTable GetTbDepartmentsByRoleId(Guid RoleId)
        {
            string sqlText = string.Format(@"select a.DepartmentId,a.RoleId,b.DepartmentName 
                    from ACL_Role_Department as a left join ACL_Department as b on a.DepartmentId=b.Id
					where a.RoleId='{0}'", RoleId);

            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }

        #endregion


        #region  获取所有功能
        public IList<Models.ACL_Function> GetAllFunction()
        {
            string sqlText = @" SELECT  * FROM [dbo].[ACL_Function] Where IsRemoved=0 ";
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            return Models.SqlHelper.DataTableToList<Models.ACL_Function>(dt);
        }

        #endregion

    }
}
