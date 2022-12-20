using Microsoft.EntityFrameworkCore;

namespace MYAZ203.Week_11
{
    public class BankingContext : DbContext
    {
        public DbSet<Banking> Banking { get; set; }
        public DbSet<Customer> Customers { get; set; }
        
        private string _connectionString;
        private MySqlServerVersion _serverVersion;
        public BankingContext()
        {
            _connectionString = "server=localhost;user=root;password=123456;database=bank-core-db";
            _serverVersion = new MySqlServerVersion(new Version(8, 0, 29));
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseMySql(_connectionString, _serverVersion);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
            modelBuilder.ApplyConfiguration(new BankingMap());
        }
    }
}
