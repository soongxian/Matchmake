using JodohFinder.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JodohFinder.Entity.Configuration
{
    public partial class JF_AGEGROUP_Configuration : IEntityTypeConfiguration<JF_AGEGROUP>
    {
        public void Configure(EntityTypeBuilder<JF_AGEGROUP> builder)
        {
            builder.ToTable("JF_AGEGROUP");
            builder.HasKey(a => a.AGE_GROUP_ID);

            builder.Property(a => a.AGE_GROUP_ID)
                   .IsRequired();

            builder.Property(a => a.AGE_GROUP_CATEGORY)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasMany(a => a.JF_PARTICIPANT)
                   .WithOne(p => p.JF_AGEGROUP)
                   .HasForeignKey(p => p.PARTICIPANT_AGEGROUP_ID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
