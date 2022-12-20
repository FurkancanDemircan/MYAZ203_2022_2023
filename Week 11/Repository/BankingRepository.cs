using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_11
{
    public class BankingRepository : ITransactionRepository
    {
        private BankingContext _context;
        private CustomerRepository _repo;

        public BankingRepository()
        {
            _context = new BankingContext();
            _repo = new CustomerRepository();
        }

        public double CheckBalance(int id)
        {
            throw new NotImplementedException();
        }

        public double Deposit(int id, double balance)
        {
            var user = _repo.GetOneUser(id);
            if (user != null)
            {
                _repo.UpdateUser(id, new Customer()
                {
                    Balance = user.Balance + balance
                });
            }

            return user.Balance;
        }

        public double Withdraw(int id, double balance)
        {
            var user = _repo.GetOneUser(id);
            if (user != null)
            {
                _repo.UpdateUser(id, new Customer()
                {
                    Balance = user.Balance - balance
                });
            }

            return user.Balance;
        }
    }
}
