namespace MYAZ203.Week_11
{
    public class CustomerRepository : IUserRepository
    {
        private BankingContext _context;

        public CustomerRepository()
        {
            _context = new BankingContext();
        }

        public void CreateUser(Customer customer)
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

        public List<Customer> GetAllUser()
        {
            return _context.Customers.ToList();
        }

        public Customer? GetOneUser(int id)
        {
            return (from customer in _context.Customers where customer.CustomerId == id select customer).FirstOrDefault();
        }

        public void UpdateUser(int id, Customer customer)
        {
            var user = GetOneUser(id);
            if (user != null)
            {
                user.CustomerName = customer.CustomerName != null ? customer.CustomerName : user.CustomerName;
                user.CustomerSurname = customer.CustomerSurname != null ? customer.CustomerSurname : user.CustomerSurname;
                user.Password = customer.Password != null ? customer.Password : user.Password;
                user.Balance = customer.Balance != 0 ? customer.Balance : user.Balance;

                _context.Update(user);
                _context.SaveChanges(true);
            }
        }
    }
}
