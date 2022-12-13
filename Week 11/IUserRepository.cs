using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_11
{
    public interface IUserRepository
    {
        // CRUD
        // Create
        public void CreateUser(Banking customer);
        //Read
        public List<Banking> GetAllUser();
        public Banking? GetOneUser(int id);
        // Update
        public void UpdateUser(int id, Banking customer);
        // Delete
        public void DeleteUser(int id);
    }
}
