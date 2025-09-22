using JodohFinder.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JodohFinder.Entity.Configuration
{
    public class JF_PARTICIPANT_Configuration : IEntityTypeConfiguration<JF_PARTICIPANT>
    {
        public void Configure(EntityTypeBuilder<JF_PARTICIPANT> builder)
        {
            builder.ToTable("JF_PARTICIPANT");

            builder.HasKey(p => p.PARTICIPANT_ID);

            builder.Property(p => p.PARTICIPANT_NAME)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(p => p.PARTICIPANT_GENDER)
                .IsRequired()
                .HasMaxLength(10);

            builder.Property(p => p.PARTICIPANT_CONTACT)
                .HasMaxLength(100);

            builder.Property(p => p.PARTICIPANT_CREDATE)
                .HasDefaultValueSql("GETUTCDATE()");

            builder.HasOne(p => p.JF_VOUCHER)
                   .WithOne(v => v.JF_PARTICIPANT)
                   .HasForeignKey<JF_PARTICIPANT>(p => p.VOUCHER_ID);

            builder.HasOne(p => p.JF_AGEGROUP)
                   .WithMany(a => a.JF_PARTICIPANT)
                   .HasForeignKey(p => p.PARTICIPANT_AGEGROUP_ID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
