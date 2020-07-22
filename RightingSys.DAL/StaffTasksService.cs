using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace RightingSys.DAL
{
    /// <summary>
    /// 任务服务类
    /// </summary>
    public  class StaffTasksService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool AddNew(Models.ys_StaffTasks model)
        {
            SqlParameter[] Param = new SqlParameter[] {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@ParentId",model.ParentId),
                new SqlParameter("@TaskName",model.TaskName),
                new SqlParameter("@Description",model.Description),
                new SqlParameter("@StaffId",model.StaffId),
                new SqlParameter("@StaffName",model.StaffName),
                new SqlParameter("@StartDate",model.StartDate),
                new SqlParameter("@DueDate",model.DueDate),
                new SqlParameter("@Priority",model.Priority),
                new SqlParameter("@Progress",model.Progress),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved)
            };

            return Models.SqlHelper.ExecuteNoQuery(@"INSERT INTO [RightingSys].[dbo].[ys_StaffTasks]
           ([Id]
           ,[ParentId]
           ,[TaskName]
           ,[Description]
           ,[StaffId]
           ,[StaffName]
           ,[StartDate]
           ,[DueDate]
           ,[Priority]
           ,[Progress]
           ,[CreateTime]
           ,[IsRemoved])
     VALUES
           (@Id
           ,@ParentId
           ,@TaskName
           ,@Description
           ,@StaffId
           ,@StaffName
           ,@StartDate
           ,@DueDate
           ,@Priority
           ,@Progress
           ,@CreateTime
           ,@IsRemoved)", Param) > 0 ? true : false;
        }

        /// <summary>
        /// 修改
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Modify(Models.ys_StaffTasks model)
        {
            SqlParameter[] Param = new SqlParameter[] {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@ParentId",model.ParentId),
                new SqlParameter("@TaskName",model.TaskName),
                new SqlParameter("@Description",model.Description),
                new SqlParameter("@StaffId",model.StaffId),
                new SqlParameter("@StaffName",model.StaffName),
                new SqlParameter("@StartDate",model.StartDate),
                new SqlParameter("@DueDate",model.DueDate),
                new SqlParameter("@Priority",model.Priority),
                new SqlParameter("@Progress",model.Progress),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved)
            };         
            // Models.SqlHelper.AddNewOperatorLog("修改用户信息", "ACL_User", "修改");

            return Models.SqlHelper.ExecuteNoQuery(@"UPDATE [RightingSys].[dbo].[ys_StaffTasks]
                SET [ParentId] = @ParentId
                   ,[TaskName] = @TaskName
                   ,[Description] = @Description
                   ,[StaffId] = @StaffId
                   ,[StaffName] = @StaffName
                   ,[StartDate] = @StartDate
                   ,[DueDate] = @DueDate
                   ,[Priority] = @Priority
                   ,[progress] = @progress
                   ,[CreateTime] = @CreateTime
                   ,[IsRemoved] = @IsRemoved
                WHERE [Id] = @Id", Param) > 0 ? true : false;
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            string sqlText = string.Format("Update  ys_StaffTasks Set IsRemoved=1 where Id='{0}'", Id);

            Models.SqlHelper.AddNewOperatorLog("删除任务信息", "ys_StaffTasks", "删除", sqlText);

            return Models.SqlHelper.ExecuteNoQuery(sqlText) > 0 ? true : false;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <returns></returns>
        public IList<Models.ys_StaffTasks> GetAllList()
        {
            string sqlText = @"SELECT [Id]
      ,[ParentId]
      ,[TaskName]
      ,[Description]
      ,[StaffId]
      ,[StaffName]
      ,[StartDate]
      ,[DueDate]
      ,[Priority]
      ,[Progress]
      ,[CreateTime]
      ,[IsRemoved]
  FROM [RightingSys].[dbo].[ys_StaffTasks]";
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            return Models.SqlHelper.DataTableToList<Models.ys_StaffTasks>(dt).ToList();

  
        }
    }
}
