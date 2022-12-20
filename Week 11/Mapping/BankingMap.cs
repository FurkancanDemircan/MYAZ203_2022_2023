using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MYAZ203.Week_11
{
    public class BankingMap : IEntityTypeConfiguration<Banking>
    {
        public void Configure(EntityTypeBuilder<Banking> builder)
        {
            builder.HasKey(b => b.CreditId);
            builder.Property(b => b.CreditName)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(b => b.Description)
                .HasMaxLength(150);
            builder.Property(b => b.Balance)
                .HasDefaultValue(0);
            builder.HasData(
                new Banking()
                {
                    CreditId = 1,
                    CreditName = "Credit 1",
                    Description = "Credit 1 desc.",
                    Balance = 10000
                },
                new Banking()
                {
                    CreditId = 2,
                    CreditName = "Credit 2",
                    Description = "Credit 2 desc.",
                    Balance = 50000
                }
                );
        }
    }
}