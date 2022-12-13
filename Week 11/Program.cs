using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_11
{
    public class Program
    {
        public static void Main()
        {
            BankingRepository repository = new BankingRepository();
            var value = repository.Withdraw(2, 300);
            Console.WriteLine(value);
            repository.GetAllUser().ForEach(
                cust=>Console.WriteLine($"{cust.Id} {cust.FullName} {cust.Balance} {cust.Password}")
                );
        }
    }
}
