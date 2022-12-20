using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_11
{
    public interface ITransactionRepository
    {
        public double Withdraw(int id, double balance);
        public double Deposit(int id, double balance);
        public double CheckBalance(int id);
    }
}
