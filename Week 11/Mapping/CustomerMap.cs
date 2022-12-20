using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MYAZ203.Week_11
{
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            builder.HasKey(c => c.CustomerId);
            builder.Property(c => c.CustomerName)
                .IsRequired();
            builder.Property(c => c.CustomerSurname)
                .IsRequired();
            builder.Property(c => c.Password)
                .HasMaxLength(12)
                .HasDefaultValue("1234");
            builder.Property(c => c.Balance)
                .HasDefaultValue(0);
            builder.Property(c => c.CreateTime)
                .HasDefaultValue(DateTime.Now);
        }
    }
}