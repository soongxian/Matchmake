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

            builder.Property(a => a.VOUCHER_USERID);

            builder.HasOne(a => a.JF_PARTICIPANT)
                   .WithOne(p => p.JF_VOUCHER)
                   .HasForeignKey<JF_PARTICIPANT>(p => p.PARTICIPANT_VOUCHER_ID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}