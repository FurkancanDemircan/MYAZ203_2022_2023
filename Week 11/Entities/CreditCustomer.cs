using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_11
{
    public class CreditCustomer
    {
        public int CCId { get; set; }

        // Customer
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }

        // Credit
        public int CreditId { get; set; }
        public Credit Credit { get; set; }
    }
}
