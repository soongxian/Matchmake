using JodohFinder.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JodohFinder.Entity.Configuration
{
    public partial class JF_ROLE_Configuration : IEntityTypeConfiguration<JF_ROLE>
    {
        public void Configure(EntityTypeBuilder<JF_ROLE> builder)
        {
            builder.ToTable("JF_ROLE");
            builder.HasKey(a => a.ROLE_ID);

            builder.Property(a => a.ROLE_ID)
                   .IsRequired();

            builder.Property(a => a.ROLE_NAME)
                   .IsRequired()
                   .HasMaxLength(50);

            builder.HasMany(a => a.JF_USER)
                   .WithOne(p => p.JF_ROLE)
                   .HasForeignKey(p => p.USER_ROLE_ID)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(
                new JF_ROLE
                {
                    ROLE_ID = Guid.Parse("ca2e98ab-f8d8-46ec-b58f-adc5d1864a05"),
                    ROLE_NAME = "Admin"
                },
                new JF_ROLE
                {
                    ROLE_ID = Guid.Parse("bf5bdf4e-f04e-479f-b106-38cc882f53e7"),
                    ROLE_NAME = "Staff"
                }
            );
        }
    }
}
