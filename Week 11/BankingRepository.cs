using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_11
{
    public class BankingRepository : IUserRepository, ITransactionRepository
    {
        private BankingContext _context;

        public BankingRepository()
        {
            _context = new BankingContext();
        }

        public double CheckBalance(int id)
        {
            throw new NotImplementedException();
        }

        public void CreateUser(Banking customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }

        public void DeleteUser(int id)
        {
            var user = GetOneUser(id);
            if (user != null)
            {
                _context.Remove(user);
                _context.SaveChanges(true);
            }
        }

        public double Deposit(int id, double balance)
        {

            var user = GetOneUser(id);
            if (user != null)
            {
                UpdateUser(id, new Banking()
                {
                    Balance = user.Balance + balance
                });
            }

            return user.Balance;
        }

        public List<Banking> GetAllUser()
        {
            return _context.Banking.ToList();
        }

        public Banking? GetOneUser(int id)
        {
            return _context.Banking.Where(customer => customer.Id == id).FirstOrDefault();
        }

        public void UpdateUser(int id, Banking customer)
        {
            var user = GetOneUser(id);
            if (user != null)
            {
                user.FirstName = customer.FirstName != null ? customer.FirstName : user.FirstName;
                user.LastName = customer.LastName != null ? customer.LastName : user.LastName;
                user.Password = customer.Password != null ? customer.Password : user.Password;
                user.Balance = customer.Balance != 0 ? customer.Balance : user.Balance;

                _context.Update(user);
                _context.SaveChanges(true);
            }
        }

        public double Withdraw(int id, double balance)
        {
            var user = GetOneUser(id);
            if (user != null)
            {
                UpdateUser(id, new Banking()
                {
                    Balance = user.Balance - balance
                });
            }

            return user.Balance;
        }
    }
}
