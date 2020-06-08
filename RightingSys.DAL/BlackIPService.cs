using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace RightingSys.DAL
{
    public class BlackIPService
    {
        /// <summary>
        /// 新增防火墙规则
        /// </summary>
        /// <param name="model">实体</param>
        /// <param name="userlist">用户列表</param>
        /// <returns></returns>
        public bool AddNew(Models.ACL_BlackIP model)
        {
            Dictionary< SqlParameter[], string> sqlDic = new Dictionary< SqlParameter[], string>();
            
            string sqlText1 = @"INSERT INTO [RightingSys].[dbo].[ACL_BlackIP]
                                ([Id]
                                ,[BlackIPName]
                                ,[AuthorizeType]
                                ,[StartIP]
                                ,[EndIP]
                                ,[OpreatorId]
                                ,[OpreatorName]
                                ,[Description]
                                ,[SystemId]
                                ,[SystemName])
                         values(  @Id
                                , @BlackIPName
                                , @AuthorizeType
                                , @StartIP
                                , @EndIP
                                , @OpreatorId
                                , @OpreatorName
                                , @Description
                                , @SystemId
                                , @SystemName)";
            SqlParameter[] Params1 = new SqlParameter[] {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@BlackIPName",model.BlackIPName),
                 new SqlParameter("@AuthorizeType",model.AuthorizeType),
                new SqlParameter("@StartIP",model.StartIP),
                 new SqlParameter("@EndIP",model.EndIP),
                new SqlParameter("@OperatorId",model.OperatorId),
                 new SqlParameter("@OperatorName",model.OperatorName),
                new SqlParameter("@Description",model.Description),
                 new SqlParameter("@SystemId",model.SystemId),
                new SqlParameter("@SystemName",model.SystemName)

            };
            sqlDic.Add(Params1,sqlText1);

            foreach (Models.ACL_BlackIP_User s in model.Details)
            {
                string SqlText2 = @"INSERT INTO [RightingSys].[dbo].[ACL_BlackIP_User]
                                   ([Id]
                                   ,[BlackIPId]
                                   ,[UserId]
                                   ,[LoginName]
                                   ,[UserName]
                                   ,[UserSimpleCode]
                                   ,[DepartmentName])
                             VALUES
                                   (@Id
                                   ,@BlackIPId
                                   ,@UserId
                                   ,@LoginName
                                   ,@UserName
                                   ,@UserSimpleCode
                                   ,@DepartmentName)";
                SqlParameter[] Params2 = new SqlParameter[] {
                new SqlParameter("@Id",s.Id),
                new SqlParameter(@"BlackIPId",s.BlackIPId),
                new SqlParameter(@"UserId",s.UserId),
                new SqlParameter("@LoginName",s.LoginName),
                new SqlParameter("@UserName", s.UserName),
                new SqlParameter(@"UserSimpleCode", s.UserSimpleCode),
                new SqlParameter(@"DepartmentName", s.DepartmentName)};

                sqlDic.Add(Params2, SqlText2);
            }

            //clsPublic.appLogs.Add_OperationLog("新增黑白名单列表", DateTime.Now, "ACL_BlackIP,ACL_BlackIP_User", "新增", string.Join("|", sqlList));
            return Models.SqlHelper.ExecuteTransaction1(sqlDic) > 0;
        }


        /// <summary>
        /// 修改防火墙规则
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool Modify(Models.ACL_BlackIP model)
        {
            string sqlText = @"UPDATE [RightingSys].[dbo].[ACL_BlackIP]
               SET [BlackIPName] = @BlackIPName
                  ,[AuthorizeType] = @AuthorizeType
                  ,[StartIP] = @StartIP
                  ,[EndIP] = @EndIP
                  ,[OpreatorId] = @OpreatorId
                  ,[OpreatorName] = @OpreatorName
                  ,[Description] = @Description
                  ,[SystemId] = @SystemId
                  ,[SystemName] = @SystemName
            WHERE[Id] = @Id";
                        //clsPublic.appLogs.Add_OperationLog("修改黑白名单列表", DateTime.Now, "ACL_BlackIP", "修改", sqlText);
            return Models.SqlHelper.ExecuteNoQuery(sqlText, new SqlParameter[] {
                 new SqlParameter("@Id",model.Id),
                new SqlParameter("@BlackIPName",model.BlackIPName),
                 new SqlParameter("@AuthorizeType",model.AuthorizeType),
                new SqlParameter("@StartIP",model.StartIP),
                 new SqlParameter("@EndIP",model.EndIP),
                new SqlParameter("@OperatorId",model.OperatorId),
                 new SqlParameter("@OperatorName",model.OperatorName),
                new SqlParameter("@Description",model.Description),
                 new SqlParameter("@SystemId",model.SystemId),
                new SqlParameter("@SystemName",model.SystemName)
            })>0;
        }

        /// <summary>
        /// 删除防火墙规则
        /// </summary>
        /// <param name="BlackIP_ID">规则Id</param>
        /// <returns></returns>
        public bool Delete(Guid BlackIPId)
        {
            Dictionary<SqlParameter[], string> sqlDic = new Dictionary<SqlParameter[], string>();

            string sqlText1 = "DELETE FROM [RightingSys].[dbo].[ACL_BlackIP] WHERE Id=@Id";
            SqlParameter[] Params1 = new SqlParameter[]{ new SqlParameter("@Id", BlackIPId) };
            sqlDic.Add(Params1, sqlText1);
           
            string SqlText2 = "DELETE FROM [RightingSys].[dbo].[ACL_BlackIP_User] WHERE BlackIPId=@BlackIPId";
            SqlParameter[] Params2 = new SqlParameter[] { new SqlParameter("@BlackIPId", BlackIPId) };
            sqlDic.Add(Params2, SqlText2);

            //clsPublic.appLogs.Add_OperationLog("新增黑白名单列表", DateTime.Now, "ACL_BlackIP,ACL_BlackIP_User", "新增", string.Join("|", sqlList));
            return Models.SqlHelper.ExecuteTransaction1(sqlDic) > 0;
        }


        /// <summary>
        /// 新增用户信息到规则
        /// </summary>
        /// <param name="list">用户列表</param>
        /// <returns></returns>
        public bool AddUserForBlackIP(List<Models.ACL_BlackIP_User> list)
        {
            Dictionary<SqlParameter[], string> sqlDic = new Dictionary<SqlParameter[], string>();
            string sqlText1 = "DELETE FROM [RightingSys].[dbo].[ACL_BlackIP_User] WHERE BlackIPId=@BlackIPId";
            SqlParameter[] Params1 = new SqlParameter[] { new SqlParameter("@Id", list[0].BlackIPId) };
            sqlDic.Add(Params1, sqlText1);
            foreach (Models.ACL_BlackIP_User s in list)
            {
                string SqlText2 = @"INSERT INTO [RightingSys].[dbo].[ACL_BlackIP_User]
                                   ([Id]
                                   ,[BlackIPId]
                                   ,[UserId]
                                   ,[LoginName]
                                   ,[UserName]
                                   ,[UserSimpleCode]
                                   ,[DepartmentName])
                             VALUES
                                   (@Id
                                   ,@BlackIPId
                                   ,@UserId
                                   ,@LoginName
                                   ,@UserName
                                   ,@UserSimpleCode
                                   ,@DepartmentName)";
                SqlParameter[] Params2 = new SqlParameter[] {
                new SqlParameter("@Id",s.Id),
                new SqlParameter(@"BlackIPId",s.BlackIPId),
                new SqlParameter(@"UserId",s.UserId),
                new SqlParameter("@LoginName",s.LoginName),
                new SqlParameter("@UserName", s.UserName),
                new SqlParameter(@"UserSimpleCode", s.UserSimpleCode),
                new SqlParameter(@"DepartmentName", s.DepartmentName)};
                sqlDic.Add(Params2, SqlText2);
            }

            //clsPublic.appLogs.Add_OperationLog("黑白名单添加用户信息", DateTime.Now, "ACL_BlackIP_User", "新增", string.Join("|", sqlList));
            return Models.SqlHelper.ExecuteTransaction1(sqlDic) > 0;
        }

        /// <summary>
        /// 移除用户信息
        /// </summary>
        /// <param name="Id">明细Id</param>
        /// <returns></returns>
        public bool RemoveUserForBlackIP(Guid Id)
        {
            string sqlTest = string.Format("Delete ACL_BlackIP_User Where [Id]='{0}'", Id);

            //  clsPublic.appLogs.Add_OperationLog("黑白名单移除用户信息", DateTime.Now, "ACL_BlackIP_User", "删除", sqlTest);
             return Models.SqlHelper.ExecuteNoQuery(sqlTest)>0;
        }

        /// <summary>
        /// 获取所有的规则信息
        /// </summary>
        /// <returns></returns>
        public List<Models.ACL_BlackIP> GetAllList()
        {
            string sqlText = string.Format(@"SELECT [Id]
                 ,[BlackIPName]
                 ,[AuthorizeType]
                 ,[StartIP]
                 ,[EndIP]
                 ,[OpreatorId]
                 ,[OpreatorName]
                 ,[Description]
                 ,[SystemId]
                 ,[SystemName]
                 ,[CreateTime]
                 ,[IsRemoved]
             FROM [RightingSys].[dbo].[ACL_BlackIP]");
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            return Models.SqlHelper.DataTableToList<Models.ACL_BlackIP>(dt).ToList() ;
        }


        /// <summary>
        /// 获取规则用户明细信息
        /// </summary>
        /// <param name="BlackIPId">规则Id</param>
        /// <returns></returns>
        public List<Models.ACL_BlackIP_User> GetUserByBlackIP(Guid BlackIPId)
        {
            string sqlText = string.Format(@"select a.Id,a.BlackIPId,a.UserId,b.FullName UserName,b.LoginName,b.SimpleCode,c.DepartmentName
                   from ACL_BlackIP_User as a inner join ACL_User as b on a.UserId=b.Id
                                               left join ACL_Department as c on b.DepartmentId=c.Id
                   where BlackIPId='{0}' ", BlackIPId);
            return Models.SqlHelper.DataTableToList<Models.ACL_BlackIP_User>( Models.SqlHelper.ExecuteDataTable(sqlText)).ToList();
        }

        #region 列表关联用户
        public System.Data.DataTable FillTableUserForBlackIP(Guid BlackIP_ID)
        {
            string sqlText = string.Format(@"  SELECT  cast( ( CASE WHEN c.[User_ID] is null THEN 0  ELSE 1 END ) as bit) IsCheck, a.[UserID],a.[LoginName],a.[LoginPwd],a.[LastLoginTime],a.[LastLoginMac],a.[LastLoginIP],a.[RoleID],a.[IsOnline],a.[FullName],a.[HandNo],a.[OUID],a.[MobilePhone],a.[Email],a.[Address],a.[Gender],a.[Birthday],a.[CardNo],a.[JoinDay],a.[Job],a.[Creator],a.[CreateDate],a.[Enabled],a.[Deleted],b.[Name] OUName
            FROM[dbo].[ACL_User] as a left join ACL_OU as b on a.OUID=b.ID
			                          left join ( SELECT * FROM  ACL_BlackIP_User  where [BlackIP_ID]='{0}' )as c on a.UserID=c.[User_ID]  ", BlackIP_ID);
            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }

        #endregion
    }
}
