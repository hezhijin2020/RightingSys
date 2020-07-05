using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace RightingSys.DAL
{
    public class StickyBookService
    {
        /// <summary>
        /// 新增
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(Models.ys_StickyBook model)
        {
            SqlParameter[] Param = new SqlParameter[] {
               new SqlParameter("@Id",model.Id),
               new SqlParameter("@StickyName",model.StickyName),
               new SqlParameter("@BranchId",model.BranchId),
               new SqlParameter("@BranchName",model.BranchName),
               new SqlParameter("@CategoryName",model.CategoryName),
               new SqlParameter("@OperatorId",model.OperatorId),
               new SqlParameter("@OperatorName",model.OperatorName),
               new SqlParameter("@StaffId",model.StaffId),
               new SqlParameter("@StaffName",model.StaffName),
               new SqlParameter("@StickyXML",model.StickyXML),
               new SqlParameter("@EditTime",model.EditTime),
               new SqlParameter("@CreateTime",model.CreateTime),
               new SqlParameter("@IsRemoved",model.IsRemoved)
            };               


            return Models.SqlHelper.ExecuteNoQuery(@"INSERT INTO [RightingSys].[dbo].[ys_StickyBook]
           ([Id]
           ,[StickyName]
           ,[BranchId]
           ,[BranchName]
           ,[CategoryName]
           ,[OperatorId]
           ,[OperatorName]
           ,[StaffId]
           ,[StaffName]
           ,[StickyXML]
           ,[EditTime]
           ,[CreateTime]
           ,[IsRemoved])
     VALUES
           (@Id
           ,@StickyName
           ,@BranchId
           ,@BranchName
           ,@CategoryName
           ,@OperatorId
           ,@OperatorName
           ,@StaffId
           ,@StaffName
           ,@StickyXML
           ,@EditTime
           ,@CreateTime
           ,@IsRemoved)", Param) > 0 ? true : false;
        }

        /// <summary>
        /// 修改便签信息
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool Modify(Models.ys_StickyBook model)
        {
            SqlParameter[] Param = new SqlParameter[] {
               new SqlParameter("@Id",model.Id),
               new SqlParameter("@StickyName",model.StickyName),
               new SqlParameter("@BranchId",model.BranchId),
               new SqlParameter("@BranchName",model.BranchName),
               new SqlParameter("@CategoryName",model.CategoryName),
               new SqlParameter("@OperatorId",model.OperatorId),
               new SqlParameter("@OperatorName",model.OperatorName),
               new SqlParameter("@StaffId",model.StaffId),
               new SqlParameter("@StaffName",model.StaffName),
               new SqlParameter("@StickyXML",model.StickyXML),
               new SqlParameter("@EditTime",model.EditTime),
               new SqlParameter("@CreateTime",model.CreateTime),
               new SqlParameter("@IsRemoved",model.IsRemoved)
            };


            // Models.SqlHelper.AddNewOperatorLog("修改用户信息", "ACL_User", "修改");

            return Models.SqlHelper.ExecuteNoQuery(@"UPDATE [RightingSys].[dbo].[ys_StickyBook]
                     SET [StickyName] = @StickyName
                        ,[BranchId] = @BranchId
                        ,[BranchName] = @BranchName
                        ,[CategoryName] = @CategoryName
                        ,[OperatorId] = @OperatorId
                        ,[OperatorName] = @OperatorName
                        ,[StaffId] = @StaffId
                        ,[StaffName] = @StaffName
                        ,[StickyXML] = @StickyXML
                        ,[EditTime] = @EditTime
                        ,[CreateTime] = @CreateTime
                        ,[IsRemoved] = @IsRemoved
                   WHERE [Id] = @Id", Param) > 0 ? true : false;
        }

        /// <summary>
        /// 删除便笺
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            string sqlText = string.Format(@"UPDATE [ys_StickyBook] SET[IsRemoved] = 1 WHERE[Id] ='{0}'", Id);
            return Models.SqlHelper.ExecuteNoQuery(sqlText) > 0 ? true : false;
        }

        /// <summary>
        /// 获取信息列表
        /// </summary>
        /// <returns></returns>
        public IList<Models.ys_StickyBook> GetAllList()
        {
            List<Models.ys_StickyBook> list = new List<Models.ys_StickyBook>();

            string sqlText = @"SELECT [Id]
      ,[StickyName]
      ,[BranchId]
      ,[BranchName]
      ,[CategoryName]
      ,[OperatorId]
      ,[OperatorName]
      ,[StaffId]
      ,[StaffName]
      ,[StickyXML]
      ,[EditTime]
      ,[CreateTime]
      ,[IsRemoved]
  FROM [RightingSys].[dbo].[ys_StickyBook]";
            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            list = Models.SqlHelper.DataTableToList<Models.ys_StickyBook>(dt).ToList();

            return list;
        }
    }
}
