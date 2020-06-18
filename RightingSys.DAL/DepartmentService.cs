using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace RightingSys.DAL
{
    public class DepartmentService 
    {
    
        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(Models.ACL_Department model)
        {
            SqlParameter[] Param = new SqlParameter[] {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@DepartmentName",model.DepartmentName),
                new SqlParameter("@SimpleCode",model.SimpleCode),
                new SqlParameter("@SortCode",model.SortCode),
                new SqlParameter("@ParentId",model.ParentId),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved)
            };

            return Models.SqlHelper.ExecuteNoQuery(@"INSERT INTO [dbo].[ACL_Department]
           ([Id]
           ,[DepartmentName]
           ,[SimpleCode]
           ,[SortCode]
           ,[ParentId]
           ,[CreateTime]
           ,[IsRemoved])
     VALUES
           (@Id
           ,@DepartmentName
           ,@SimpleCode
           ,@SortCode
           ,@ParentId
           ,@CreateTime
           ,@IsRemoved)", Param) > 0 ? true : false;
        }

        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool Modify(Models.ACL_Department model)
        {
            SqlParameter[] Param = new SqlParameter[] {
                new SqlParameter("@Id",model.Id),
                new SqlParameter("@DepartmentName",model.DepartmentName),
                new SqlParameter("@SimpleCode",model.SimpleCode),
                new SqlParameter("@SortCode",model.SortCode),
                new SqlParameter("@ParentId",model.ParentId),
                new SqlParameter("@CreateTime",model.CreateTime),
                new SqlParameter("@IsRemoved",model.IsRemoved)
                    };


            return Models.SqlHelper.ExecuteNoQuery(@"UPDATE [dbo].[ACL_Department]
                SET  [DepartmentName] = @DepartmentName
                    ,[SimpleCode] = @SimpleCode
                    ,[SortCode] = @SortCode
                    ,[ParentId] = @ParentId
                    ,[CreateTime] = @CreateTime
                    ,[IsRemoved] = @IsRemoved
                WHERE [Id] = @Id", Param) > 0 ? true : false;
        }


        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="Id">部门Id</param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
            string sqlText = string.Format("Delete ACL_Department where Id='{0}'", Id);
            return Models.SqlHelper.ExecuteNoQuery(sqlText) > 0 ? true : false;
        }

        /// <summary>
        /// 检查指定部门下是否在用户
        /// </summary>
        /// <param name="Id">部门Id</param>
        /// <returns></returns>
        public bool ExistsUserById(Guid Id)
        {
            string sqlText = @"select COUNT([Id])from ACL_User where DepartmentId=@Id";
            SqlParameter s1 = new SqlParameter("@Id", Id);
            return Models.SqlHelper.ExecuteNoQuery(sqlText, s1)>0?true:false;
        }

        /// <summary>
        /// 查看部门ID是否存在
        /// </summary>
        /// <param name="Id">部门ID</param>
        /// <returns></returns>
        public bool ExistsById(Guid Id)
        {
            string sqlText = "select count(Id) from ACL_Department where Id='{0}' ";
            return Models.SqlHelper.ExecuteScalar(sqlText).ToString() == "0" ? false : true;
        }


        /// <summary>
        /// 检查指定名称的部门是否存在
        /// </summary>
        /// <param name="departmentName">部门名称</param>
        /// <returns></returns>
        public bool ExistsByName(string departmentName)
        {
            string sqlText = string.Format("select count(Id) from ACL_Department where  DepartmentName ='{0}' ",departmentName);
            return Models.SqlHelper.ExecuteScalar(sqlText).ToString() == "0" ? false : true;
        }

        /// <summary>
        /// 获取所有部门列表
        /// </summary>
        /// <returns></returns>

        public IList<Models.ACL_Department> GetAllList()
        {
            List<Models.ACL_Department> list = new List<Models.ACL_Department>();

            string sqlText = "select * from ACL_Department";
            System.Data.DataTable dt= Models.SqlHelper.ExecuteDataTable(sqlText);
            list = Models.SqlHelper.DataTableToList<Models.ACL_Department>(dt).ToList();
            return list;
        }

        /// <summary>
        /// 获取引用指定部门的角色列表
        /// </summary>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public List<Models.ACL_Role> GetRoleListByDepartmentId(Guid departmentId)
        {
            string sqlText = string.Format(@"SELECT distinct b.*
 FROM [RightingSys].[dbo].[ACL_Role_Department] as a inner join RightingSys.dbo.ACL_Role as b on a.RoleId=b.Id
 where a.IsRemoved=0 and b.IsRemoved=0 and a.DepartmentId='{0}'", departmentId);

            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
          return  Models.SqlHelper.DataTableToList<Models.ACL_Role>(dt).ToList();
            
        }

        /// <summary>
        /// 获取引用指定部门的用户列表
        /// </summary>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public List<Models.ACL_User> GetUserListByDepartmentId(Guid departmentId)
        {
            string sqlText = string.Format(@"select * from RightingSys.dbo.ACL_User where IsRemoved=0 and DepartmentId='{0}'", departmentId);

            System.Data.DataTable dt = Models.SqlHelper.ExecuteDataTable(sqlText);
            return Models.SqlHelper.DataTableToList<Models.ACL_User>(dt).ToList();
        }

    }
}