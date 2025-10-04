using JodohFinder.Domain;
using JodohFinder.Entity.Configuration;
using Microsoft.EntityFrameworkCore;

namespace JodohFinder.DbContextEF
{
    public class DbContextCore : DbContext
    {
        public DbContextCore(DbContextOptions<DbContextCore> dbContextOptions) : base(dbContextOptions) { }

        public virtual DbSet<JF_AGEGROUP> JF_AgeGroup { get; set; }
        public virtual DbSet<JF_PARTICIPANT> JF_Participant { get; set; }
        public virtual DbSet<JF_ROLE> JF_Role { get; set; }
        public virtual DbSet<JF_USER> JF_User { get; set; }
        public virtual DbSet<JF_VOUCHER> JF_Voucher { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JF_AGEGROUP_Configuration());
            modelBuilder.ApplyConfiguration(new JF_PARTICIPANT_Configuration());
            modelBuilder.ApplyConfiguration(new JF_ROLE_Configuration());
            modelBuilder.ApplyConfiguration(new JF_USER_Configuration());
            modelBuilder.ApplyConfiguration(new JF_VOUCHER_Configuration());
        }
    }
}
