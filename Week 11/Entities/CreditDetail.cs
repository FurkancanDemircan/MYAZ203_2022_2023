using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYAZ203.Week_11
{
    public class CreditDetail
    {
        public int CDId { get; set; }
        public string CreditDescription { get; set; }
        public double MinValue { get; set; }
        public double MaxValue { get; set; }

        public Credit Credit { get; set; }
        public int CreditId { get; set; }
    }
}
