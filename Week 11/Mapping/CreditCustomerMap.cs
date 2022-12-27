using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MYAZ203.Week_11
{
    public class CreditCustomerMap : IEntityTypeConfiguration<CreditCustomer>
    {
        public void Configure(EntityTypeBuilder<CreditCustomer> builder)
        {
            builder.HasKey(cc=>cc.CCId);
            builder.HasOne(cc => cc.Customer)
                .WithMany(c => c.CreditCustomers)
                .HasForeignKey(cc => cc.CustomerId);
            builder.HasOne(b => b.Credit)
                .WithMany(cc => cc.CreditCustomers)
                .HasForeignKey(cc => cc.CreditId);
        }
    }
}