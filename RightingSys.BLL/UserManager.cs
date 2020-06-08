using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;

namespace RightingSys.BLL
{
    public class UserManager
    {
        DAL.UserService Sev = new DAL.UserService();

        public bool AddNew(Models.ACL_User model)
        {
            return Sev.AddNew(model);
        }

        public bool Modify(Models.ACL_User model)
        {
            return Sev.Modify(model);
        }

        public bool Delete(Guid Id)
        {
            return Sev.Delete(Id);
        }

        public bool ExistsById(Guid Id)
        {
            return Sev.ExistsById(Id);
        }

        public bool ExistsByName(string Name)
        {
            return Sev.ExistsByName(Name);
        }

        public List<Models.ACL_User> GetAllList()
        {
            
            return Sev.GetAllList().ToList();
        }

        public Models.ACL_User GetOneById(Guid Id)
        {
            return Sev.GetOneById(Id);
        }

    }
}
