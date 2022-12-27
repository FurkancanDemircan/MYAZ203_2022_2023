
namespace MYAZ203.Week_11
{
    public class Credit
    {
        // Banking
        public int CreditId { get; set; }
        public string CreditName { get; set; }

        // Detail
        public CreditDetail CreditDetail { get; set; }

        // Customer-Credit
        public List<CreditCustomer> CreditCustomers { get; set; }

    }
}