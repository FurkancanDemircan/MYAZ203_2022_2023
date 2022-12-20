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
            CustomerRepository customerRepository = new CustomerRepository();
            BankingRepository bankingRepository = new BankingRepository();
            var value = bankingRepository.Withdraw(2, 300);
            Console.WriteLine(value);
            customerRepository.GetAllUser().ForEach(
                cust => Console.WriteLine($"{cust.CustomerId} {cust.FullName} {cust.Balance} {cust.Password}")
                );
        }
    }
}
