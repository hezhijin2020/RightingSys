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
        /// 新增档案
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(Models.ys_JobFiles model)
        {
            string sqlText = @"INSERT INTO [RightingSys].[dbo].[ys_JobFiles]
           ([Id]
           ,[JobFileName]
           ,[JobFileCategoryId]
           ,[JobFileCategoryName]
           ,[JobFileStaffId]
           ,[JobFileStaffName]
           ,[FileImage]
           ,[OperatorId]
           ,[OperatorName]
           ,[AuditorId]
           ,[AuditorName]
           ,[Auditorday]
           ,[Description]
           ,[CreateTime]
           ,[IsRemoved])
     VALUES
           (@Id
           ,@JobFileName
           ,@JobFileCategoryId
           ,@JobFileCategoryName
           ,@JobFileStaffId
           ,@JobFileStaffName
           ,@FileImage
           ,@OperatorId
           ,@OperatorName
           ,@AuditorId
           ,@AuditorName
           ,@Auditorday
           ,@Description
           ,@CreateTime
           ,@IsRemoved)";

            SqlParameter[] Params = new SqlParameter[] {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@JobFileName",model.JobFileName),
                new SqlParameter("@JobFileCategoryId",model.JobFileCategoryId),
                new SqlParameter("@JobFileCategoryName",model.JobFileCategoryName),
                new SqlParameter("@JobFileStaffId",model.JobFileStaffId),
                new SqlParameter("@JobFileStaffName",model.JobFileStaffName),
                new SqlParameter("@FileImage",model.FileImage),
                new SqlParameter("@OperatorId",model.OperatorId),
                new SqlParameter("@OperatorName",model.OperatorName),
                new SqlParameter("@AuditorId",model.AuditorId),
                new SqlParameter("@AuditorName",model.AuditorName),
                new SqlParameter("@Auditorday",model.Auditorday),
                new SqlParameter("@Description",model.Description),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved)
            };


            return Models.SqlHelper.ExecuteNoQuery(sqlText, Params)>0;
        }

        /// <summary>
        /// 档案删除( 伪删除)
        /// </summary>
        /// <param name="Id">档案ID</param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            string sqlText = @"UPDATE  [RightingSys].[dbo].[ys_JobFiles] SET [IsRemoved]=1  WHERE [Id]=@Id";
            return Models.SqlHelper.ExecuteNoQuery(sqlText, new SqlParameter("@Id", Id)) > 0;
        }

        /// <summary>
        /// 获取所有的档案列表
        /// </summary>
        /// <returns></returns>
        public IList<Models.ys_JobFiles> GetAllList()
        {
            string sqlText = @"SELECT [Id]
      ,[JobFileName]
      ,[JobFileCategoryId]
      ,[JobFileCategoryName]
      ,[JobFileStaffId]
      ,[JobFileStaffName]
      ,[FileImage]
      ,[OperatorId]
      ,[OperatorName]
      ,[AuditorId]
      ,[AuditorName]
      ,[Auditorday]
      ,[Description]
      ,[CreateTime]
      ,[IsRemoved]
  FROM [RightingSys].[dbo].[ys_JobFiles]";
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);

            return Models.SqlHelper.DataTableToList<Models.ys_JobFiles>(dt);
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
    }
}
