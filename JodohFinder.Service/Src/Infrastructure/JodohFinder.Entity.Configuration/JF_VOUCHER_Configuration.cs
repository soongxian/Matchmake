using JodohFinder.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JodohFinder.Entity.Configuration
{
    public partial class JF_VOUCHER_Configuration : IEntityTypeConfiguration<JF_VOUCHER>
    {
        public void Configure(EntityTypeBuilder<JF_VOUCHER> builder)
        {
            builder.ToTable("JF_VOUCHER");
            builder.HasKey(a => a.VOUCHER_ID);

            builder.Property(a => a.VOUCHER_CODE)
                   .IsRequired();

            builder.Property(a => a.VOUCHER_CREDATE)
                   .IsRequired();

            builder.Property(a => a.VOUCHER_USEDATE);
        }
    }
}