using JodohFinder.Domain;
using Microsoft.EntityFrameworkCore;

namespace JodohFinder.JFDbContext
{
    public class JFDbContext : DbContext
    {
        public JFDbContext(DbContextOptions<JFDbContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<JF_AGEGROUP> JF_AgeGroup { get; set; }
        public DbSet<JF_PARTICIPANT> JF_Participant { get; set; }
        public DbSet<JF_ROLE> JF_Role { get; set; }
        public DbSet<JF_USER> JF_User { get; set; }
        public DbSet<JF_VOUCHER> JF_Voucher { get; set; }
    }
}
