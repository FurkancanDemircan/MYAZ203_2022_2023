namespace MYAZ203.Week_11
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string FullName => CustomerName + " " + CustomerSurname;
        public string Password { get; set; }
        public double Balance { get; set; }

        // DD.MM.YYYY
        public DateTime CreateTime { get; set; }

        public List<CreditCustomer> CreditCustomers { get; set; }

        public Customer()
        {
            Balance = 0;
            Password = "1234";
            CreateTime = DateTime.Now;
        }

    }
}