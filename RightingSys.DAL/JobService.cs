using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace RightingSys.DAL
{
    public  class JobService
    {
        /// <summary>
        /// 新增工作记录
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(Models.ys_JobRecord model)
        {
            string sqlText = @"INSERT INTO [RightingSys].[dbo].[ys_JobRecord]
           ([Id]
           ,[BranchId]
           ,[BranchName]
           ,[StaffId]
           ,[StaffName]
           ,[CategoryId]
           ,[CategoryName]
           ,[Contact]
           ,[ContactNumber]
           ,[Description]
           ,[CreatorId]
           ,[CreatorName])
     VALUES(@Id
           ,@BranchId
           ,@BranchName
           ,@StaffId
           ,@StaffName
           ,@CategoryId
           ,@CategoryName
           ,@Contact
           ,@ContactNumber
           ,@Description
           ,@CreatorId
           ,@CreatorName)";

            SqlParameter[] Params = new SqlParameter[] {
                new SqlParameter("@Id",model.Id=Guid.NewGuid()),
                new SqlParameter("@BranchId",model.BranchId),
                new SqlParameter("@BranchName",model.BranchName),
                new SqlParameter("@StaffId",model.StaffId),
                new SqlParameter("@StaffName",model.StaffName),
                new SqlParameter("@CategoryId",model.CategoryId),
                new SqlParameter("@CategoryName",model.CategoryName=""),
                new SqlParameter("@Contact",model.Contact),
                new SqlParameter("@ContactNumber",model.ContactNumber=""),
                new SqlParameter("@Description",model.Description),
                new SqlParameter("@CreatorId",model.CreatorId),
                new SqlParameter("@CreatorName",model.CreatorName) };

            return Models.SqlHelper.ExecuteNoQuery(sqlText, Params)>0;
        }


        /// <summary>
        /// 修改工作记录
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool Modify(Models.ys_JobRecord model)
        {
            string sqlText = @"UPDATE [RightingSys].[dbo].[ys_JobRecord]
                               SET [BranchId] = @BranchId
                                  ,[BranchName] = @BranchName
                                  ,[StaffId] = @StaffId
                                  ,[StaffName] = @StaffName
                                  ,[CategoryId] = @CategoryId
                                  ,[CategoryName] = @CategoryName
                                  ,[Contact] = @Contact
                                  ,[ContactNumber] = @ContactNumber
                                  ,[Description] = @Description
                                  ,[CreateTime]=@CreateTime
                                  ,[Solution] = @Solution
                                  ,[OperatorId] = @OperatorId
                                  ,[OperatorName] = @OperatorName
                                  ,[FinishTime] = @FinishTime
                                  ,[TotalMins] = DATEDIFF(N,@CreateTime,ISNULL(@FinishTime,GETDATE()))
                                  ,[IsFinish] = @IsFinish
                             WHERE [Id] = @Id";

            SqlParameter[] Params = new SqlParameter[] {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@BranchId",model.BranchId),
                new SqlParameter("@BranchName",model.BranchName),
                new SqlParameter("@StaffId",model.StaffId),
                new SqlParameter("@StaffName",model.StaffName),
                new SqlParameter("@CategoryId",model.CategoryId),
                new SqlParameter("@CategoryName",model.CategoryName),
                new SqlParameter("@Contact",model.Contact),
                new SqlParameter("@ContactNumber",model.ContactNumber),
                new SqlParameter("@Description",model.Description),
                new SqlParameter("@Solution",model.Solution),
                new SqlParameter("@OperatorId",model.OperatorId),
                new SqlParameter("@OperatorName",model.OperatorName),
                new SqlParameter("@FinishTime",model.FinishTime),
                //new SqlParameter("@TotalMins",model.TotalMins),
                new SqlParameter("@IsFinish", model.IsFinish),
                new SqlParameter("@CreateTime", model.CreateTime),
            };

            return Models.SqlHelper.ExecuteNoQuery(sqlText, Params) > 0;
        }




        /// <summary>
        /// 工作记录删除( 伪删除)
        /// </summary>
        /// <param name="Id">工作记录ID</param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            string sqlText = @"UPDATE  [RightingSys].[dbo].[ys_JobRecord] SET [IsRemoved]=1  WHERE [Id]=@Id";
            return Models.SqlHelper.ExecuteNoQuery(sqlText, new SqlParameter("@Id", Id)) > 0;
        }

        /// <summary>
        /// 获取所有的工作记录列表
        /// </summary>
        /// <returns></returns>
        public IList<Models.ys_JobRecord> GetAllList()
        {
            string sqlText = @"SELECT [Id]
      ,[BranchId]
      ,[BranchName]
      ,[StaffId]
      ,[StaffName]
      ,[CategoryId]
      ,[CategoryName]
      ,[Contact]
      ,[ContactNumber]
      ,[Description]
      ,[CreatorId]
      ,[CreatorName]
      ,[CreateTime]
      ,[Solution]
      ,[OperatorId]
      ,[OperatorName]
      ,[FinishTime]
      ,[TotalMins]=DATEDIFF(N,CreateTime,ISNULL(FinishTime,GETDATE()))
      ,[IsFinish]
      ,[IsRemoved]
  FROM [RightingSys].[dbo].[ys_JobRecord]";
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);

            return Models.SqlHelper.DataTableToList<Models.ys_JobRecord>(dt);
        }


        #region 类别方法

        /// <summary>
        /// 新增类别方法
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddNewCategory(Models.ys_JobCategory model)
        {
            string sqlText = @"
                  INSERT INTO [RightingSys].[dbo].[ys_JobCategory]
                ([Id]
                ,[JobCategoryName]
                ,[ParentId]
                ,[CreateTime]
                ,[IsRemoved])
          VALUES
                (@Id
                ,@JobCategoryName
                ,@ParentId
                ,@CreateTime
                ,@IsRemoved)";

            SqlParameter[] param =new SqlParameter[]{
                new SqlParameter("@JobCategoryName",model.JobCategoryName),
                new SqlParameter("@ParentId",model.ParentId),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved),
                new SqlParameter("@Id",model.Id)
                };

            return Models.SqlHelper.ExecuteNoQuery(sqlText, param) > 0;
        }

        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool ModifyCategory(Models.ys_JobCategory model)
        {
            string sqlText = @"
             UPDATE [RightingSys].[dbo].[ys_JobCategory]
                SET [JobCategoryName] = @JobCategoryName
                   ,[ParentId] = @ParentId
                   ,[CreateTime] = @CreateTime
                   ,[IsRemoved] = @IsRemoved
              WHERE [Id] = @Id";

            SqlParameter[] parameters = new SqlParameter[] {
                new SqlParameter("@JobCategoryName",model.JobCategoryName),
                new SqlParameter("@ParentId",model.ParentId),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved),
                new SqlParameter("@Id",model.Id)
                };
            
            return Models.SqlHelper.ExecuteNoQuery(sqlText, parameters) > 0;
        }

        /// <summary>
        /// 删除指定的类别（伪删 除）
        /// </summary>
        /// <param name="ID">类别ID</param>
        /// <returns></returns>
        public bool DeleteCategory(Guid CategoryId)
        {

            string sqlText = @"UPDATE [RightingSys].[dbo].[ys_JobCategory] SET[IsRemoved] = @IsRemoved WHERE  [Id] = @Id";

            SqlParameter[] parameters = new SqlParameter[] {
                    new SqlParameter("@Id",CategoryId),
                    new SqlParameter("@IsRemoved",1)};

            return Models.SqlHelper.ExecuteNoQuery(sqlText,parameters)>0;
        }

       
        /// <summary>
        /// 获取所有的类别列表
        /// </summary>
        /// <returns></returns>
        public IList<Models.ys_JobCategory> GetAllListCategory()
        {
            string sqlText = @"SELECT [Id]
                ,[JobCategoryName]
                ,[ParentId]
                ,[CreateTime]
                ,[IsRemoved]
            FROM [RightingSys].[dbo].[ys_JobCategory]";

            DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);

            return Models.SqlHelper.DataTableToList<Models.ys_JobCategory>(dt).ToList();
        
        }
        #endregion


        /// <summary>
        /// 获取机构信息
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable GetDtBranch()
        {
            string sqlText = @"select  RTRIM(a.branchcode) BranchId,a.[NAME] BranchDesc,a.keeperclientid ClientId,b.clientdesc ClientDesc,a.updatedate Wno
            from ys_branch as a  left join ys_client  as b on a.keeperclientid=b.clientid
            where a.branchcode is not null and b.ManAgentClientID='AHUN'
            order by a.branchcode asc";

            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }

        /// <summary>
        /// 分析
        /// </summary>
        /// <returns></returns>
        public System.Data.DataTable GetDtAnalyzeJob(string Where)
        {
            string sqlText = string.Format(@"select a.BranchId,a.BranchName,e.ClientDesc,a.Contact,a.[Description],a.CreatorName,a.CreateTime,a.CategoryName,a.Solution,a.OperatorName, a.FinishTime,TotalMins,1 QTY,h.DepartmentName,a.StaffName
            from ys_JobRecord as a  left join ( 
            select  RTRIM(c.branchcode) BranchId,c.[NAME] BranchDesc,c.keeperclientid ClientId,d.Clientdesc,c.updatedate Wno
            from ys_branch as c  left join ys_client  as d on c.keeperclientid=d.clientid
            where c.branchcode is not null and d.ManAgentClientID='AHUN'
            ) as e on a.BranchId=e.BranchId
            left join (select f.Id,f.FullName,f.DepartmentId,g.DepartmentName from ACL_User as f left join ACL_Department as g on f.DepartmentId=g.Id) as h 
            on a.StaffId=h.Id
            where a.IsRemoved=0 and a.IsFinish=1 {0}",Where);

            return Models.SqlHelper.ExecuteDataTable(sqlText);
        }
    }
}
