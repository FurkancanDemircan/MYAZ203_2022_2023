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
        public void CreateUser(Customer customer);
        //Read
        public List<Customer> GetAllUser();
        public Customer? GetOneUser(int id);
        // Update
        public void UpdateUser(int id, Customer customer);
        // Delete
        public void DeleteUser(int id);
    }
}
