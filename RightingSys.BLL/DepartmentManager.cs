using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace RightingSys.BLL
{
    public class DepartmentManager
    {
        DAL.DepartmentService Sev = new DAL.DepartmentService();

        public bool AddNew(Models.ACL_Department model)
        {
           return Sev.AddNew(model);
        }

        public bool Modify(Models.ACL_Department model)
        {
            return Sev.Modify(model);
        }

        public bool Delete(Guid Id)
        {
           return Sev.Delete(Id);
        }

        public bool ExistsUserById(Guid Id)
        {

            return Sev.ExistsUserById(Id);
        }

        public bool ExistsById(Guid Id)
        {
           return Sev.ExistsById(Id);
        }

        public bool ExistsByName(Guid Id)
        {
           return Sev.ExistsByName(Id);
        }

        public List<Models.ACL_Department> GetAllList()
        {
           return Sev.GetAllList().ToList();
        }

        public  Models.ACL_Department GetOneById(Guid Id)
        {
            return Sev.GetOneById(Id);
        }
    }
}