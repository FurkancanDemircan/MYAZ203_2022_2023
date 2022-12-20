using Microsoft.EntityFrameworkCore;

namespace MYAZ203.Week_11
{
    public class Banking
    {
        // Banking
        public int CreditId { get; set; }
        public string CreditName { get; set; }
        public string Description { get; set; }
        public double Balance { get; set; }

        public Banking()
        {
            Balance = 0;
        }
    }
}