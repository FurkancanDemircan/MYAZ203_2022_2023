using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MYAZ203.Week_11
{
    public class CreditDetailMap : IEntityTypeConfiguration<CreditDetail>
    {
        public void Configure(EntityTypeBuilder<CreditDetail> builder)
        {
            builder.HasKey(cd => cd.CDId);
            builder.Property(cd => cd.MinValue)
                .HasDefaultValue(2000);
            builder.Property(cd => cd.MaxValue)
                .HasDefaultValue(50000);
            builder.HasOne(b => b.Credit)
                .WithOne(cd => cd.CreditDetail)
                .HasForeignKey<CreditDetail>(cd=>cd.CreditId);
        }
    }
}