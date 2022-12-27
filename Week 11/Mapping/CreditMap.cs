using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MYAZ203.Week_11
{
    public class CreditMap : IEntityTypeConfiguration<Credit>
    {
        public void Configure(EntityTypeBuilder<Credit> builder)
        {
            builder.HasKey(b => b.CreditId);
            builder.Property(b => b.CreditName)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasData(
                new Credit()
                {
                    CreditId = 1,
                    CreditName = "Credit 1",
                },
                new Credit()
                {
                    CreditId = 2,
                    CreditName = "Credit 2",
                }
                );
        }
    }
}