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
                                ,[OperatorId]
                                ,[OperatorName]
                                ,[Description]
                                ,[SystemId]
                                ,[SystemName]
                                ,[IsRemoved])
                         values(  @Id
                                , @BlackIPName
                                , @AuthorizeType
                                , @StartIP
                                , @EndIP
                                , @OperatorId
                                , @OperatorName
                                , @Description
                                , @SystemId
                                , @SystemName
                                ,@IsRemoved)";
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
                new SqlParameter("@SystemName",model.SystemName),
                new SqlParameter("@IsRemoved",model.IsRemoved)
            };
            sqlDic.Add(Params1,sqlText1);

            foreach (Models.ACL_User s in model.Details)
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
                new SqlParameter("@Id",Guid.NewGuid()),
                new SqlParameter(@"BlackIPId",model.Id),
                new SqlParameter(@"UserId",s.Id),
                new SqlParameter("@LoginName",s.LoginName),
                new SqlParameter("@UserName", s.FullName),
                new SqlParameter(@"UserSimpleCode", s.SimpleCode),
                new SqlParameter(@"DepartmentName", s.DepartmentName)};

                sqlDic.Add(Params2, SqlText2);
            }

            Models.SqlHelper.AddNewOperatorLog("新增黑白名单", "ACL_BlackIP,ACL_BlackIP_User","新增",string.Join(" # ",sqlDic));
            return Models.SqlHelper.ExecuteTransaction1(sqlDic) > 0;
        }


        /// <summary>
        /// 修改防火墙规则
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool Modify(Models.ACL_BlackIP model)
        {
            Dictionary<SqlParameter[], string> sqlDic = new Dictionary<SqlParameter[], string>();

            string sqlText1 = @"UPDATE [RightingSys].[dbo].[ACL_BlackIP]
               SET [BlackIPName] = @BlackIPName
                  ,[AuthorizeType] = @AuthorizeType
                  ,[StartIP] = @StartIP
                  ,[EndIP] = @EndIP
                  ,[OperatorId] = @OperatorId
                  ,[OperatorName] = @OperatorName
                  ,[Description] = @Description
                  ,[SystemId] = @SystemId
                  ,[SystemName] = @SystemName
                  ,[IsRemoved]=@IsRemoved
            WHERE[Id] = @Id";

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
                new SqlParameter("@SystemName",model.SystemName),
                 new SqlParameter("@IsRemoved",model.IsRemoved)

            };
            sqlDic.Add(Params1, sqlText1);

            string sqlText3 = "DELETE FROM [RightingSys].[dbo].[ACL_BlackIP_User] WHERE BlackIPId=@BlackIPId";
            SqlParameter[] Params3 = new SqlParameter[] { new SqlParameter("@BlackIPId", model.Id) };
            sqlDic.Add(Params3, sqlText3);

            foreach (Models.ACL_User s in model.Details)
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
                new SqlParameter("@Id",Guid.NewGuid()),
                new SqlParameter(@"BlackIPId",model.Id),
                new SqlParameter(@"UserId",s.Id),
                new SqlParameter("@LoginName",s.LoginName),
                new SqlParameter("@UserName", s.FullName),
                new SqlParameter(@"UserSimpleCode", s.SimpleCode),
                new SqlParameter(@"DepartmentName", s.DepartmentName)};

                sqlDic.Add(Params2, SqlText2);
            }
            Models.SqlHelper.AddNewOperatorLog("修改黑白名单", "ACL_BlackIP,ACL_BlackIP_User", "修改", string.Join(" # ", sqlDic));
            return Models.SqlHelper.ExecuteTransaction1(sqlDic) > 0;
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

            Models.SqlHelper.AddNewOperatorLog("删除黑白名单", "ACL_BlackIP,ACL_BlackIP_User", "删除", string.Join(" # ", sqlDic));
            return Models.SqlHelper.ExecuteTransaction1(sqlDic) > 0;
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
                 ,[OperatorId]
                 ,[OperatorName]
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
        public List<Models.ACL_User> GetUserByBlackIP(Guid BlackIPId)
        {
            string sqlText = string.Format(@" select a.*,b.DepartmentName
            from ACL_User as a left join ACL_Department as b on a.DepartmentId = b.Id
                               inner join ACL_BlackIP_User as c on a.Id=c.UserId
            where a.IsRemoved = 0  and c.BlackIPId='{0}'", BlackIPId);
            return Models.SqlHelper.DataTableToList<Models.ACL_User>( Models.SqlHelper.ExecuteDataTable(sqlText)).ToList();
        }
    }
}
