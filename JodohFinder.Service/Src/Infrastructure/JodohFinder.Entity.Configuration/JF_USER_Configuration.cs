using JodohFinder.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JodohFinder.Entity.Configuration
{
    public partial class JF_USER_Configuration : IEntityTypeConfiguration<JF_USER>
    {
        public void Configure(EntityTypeBuilder<JF_USER> builder)
        {
            builder.ToTable("JF_USER");
            builder.HasKey(a => a.USER_ID);

            builder.Property(a => a.USER_USERNAME)
                   .IsRequired();

            builder.Property(a => a.USER_PASSWORD)
                   .IsRequired();

            builder.HasOne(a => a.JF_ROLE)
                   .WithMany(p => p.JF_USER)
                   .HasForeignKey(p => p.USER_ROLE_ID)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
