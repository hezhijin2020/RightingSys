using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace RightingSys.BLL
{
    public class DepartmentManager
    {
        DAL.DepartmentService Sev = new DAL.DepartmentService();


        /// <summary>
        /// 新增部门
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool AddNew(Models.ACL_Department model)
        {
           return Sev.AddNew(model);
        }

        /// <summary>
        /// 修改部门
        /// </summary>
        /// <param name="model">实体</param>
        /// <returns></returns>
        public bool Modify(Models.ACL_Department model)
        {
            return Sev.Modify(model);
        }

        /// <summary>
        /// 删除部门
        /// </summary>
        /// <param name="Id">部门Id</param>
        /// <returns></returns>
        public bool Delete(Guid Id)
        {
           return Sev.Delete(Id);
        }

        /// <summary>
        /// 检查指定部门下是否在用户
        /// </summary>
        /// <param name="Id">部门Id</param>
        /// <returns></returns>
        public bool ExistsUserById(Guid Id)
        {

            return Sev.ExistsUserById(Id);
        }

        /// <summary>
        /// 查看部门ID是否存在
        /// </summary>
        /// <param name="Id">部门ID</param>
        /// <returns></returns>
        public bool ExistsById(Guid Id)
        {
           return Sev.ExistsById(Id);
        }

        /// <summary>
        /// 检查指定名称的部门是否存在
        /// </summary>
        /// <param name="departmentName">部门名称</param>
        /// <returns></returns>
        public bool ExistsByName(string departmentName)
        {
           return Sev.ExistsByName(departmentName);
        }

        /// <summary>
        /// 获取所有部门列表
        /// </summary>
        /// <returns></returns>
        public List<Models.ACL_Department> GetAllList()
        {
           return Sev.GetAllList().Where(a=>a.IsRemoved==false).ToList();
        }

        /// <summary>
        /// 获取指定部门ID的实体
        /// </summary>
        /// <param name="Id">部门ID</param>
        /// <returns></returns>
        public  Models.ACL_Department GetOneById(Guid Id)
        {
            return GetAllList().FirstOrDefault(a=>a.Id==Id);
        }

        /// <summary>
        /// 获取引用指定部门的角色列表
        /// </summary>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public List<Models.ACL_Role> GetRoleListByDepartmentId(Guid departmentId)
        {
            return Sev.GetRoleListByDepartmentId(departmentId);

        }

        /// <summary>
        /// 获取引用指定部门的用户列表
        /// </summary>
        /// <param name="departmentId">部门ID</param>
        /// <returns></returns>
        public List<Models.ACL_User> GetUserListByDepartmentId(Guid departmentId)
        {
            return Sev.GetUserListByDepartmentId(departmentId);
        }

    }
}