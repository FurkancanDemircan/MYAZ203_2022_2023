using Microsoft.EntityFrameworkCore;

namespace MYAZ203.Week_11
{
    public class BankingContext : DbContext
    {
        public DbSet<Credit> Credits { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<CreditDetail> CreditsDetails { get; set; }
        public DbSet<CreditCustomer> CreditCustomers { get; set; }


        private string _connectionString;
        private MySqlServerVersion _serverVersion;
        public BankingContext()
        {
            // _connectionString = "server=localhost;user=root;password=123456;database=bank-core-db";
            // _serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
            _connectionString = "Data Source=localhost;Initial Catalog=localdb;Integrated Security=True;Encrypt=False";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => //options.UseMySql(_connectionString, _serverVersion);
            options.UseSqlServer(_connectionString);
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new CreditMap());
            modelBuilder.ApplyConfiguration(new CreditDetailMap());
            modelBuilder.ApplyConfiguration(new CreditCustomerMap());
        }
    }
}
