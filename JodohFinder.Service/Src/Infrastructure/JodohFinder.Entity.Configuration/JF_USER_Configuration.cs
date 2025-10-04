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

            builder.HasData(
                new JF_USER
                {
                    USER_ID = Guid.Parse("82417f8a-4801-4fb3-8c73-b6d93371fe82"),
                    USER_USERNAME = "admin",
                    USER_PASSWORD = "admin",
                    USER_ROLE_ID = Guid.Parse("ca2e98ab-f8d8-46ec-b58f-adc5d1864a05")
                }
            );
        }
    }
}
