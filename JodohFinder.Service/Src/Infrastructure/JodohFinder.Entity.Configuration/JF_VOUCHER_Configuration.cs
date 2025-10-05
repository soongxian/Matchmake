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

            builder.HasOne(a => a.JF_USER)
                   .WithMany(p => p.JF_VOUCHER)
                   .HasForeignKey(p => p.VOUCHER_CREBY)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Property(a => a.VOUCHER_USEDATE);
        }
    }
}