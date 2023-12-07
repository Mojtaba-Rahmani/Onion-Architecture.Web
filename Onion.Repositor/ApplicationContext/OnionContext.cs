using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Onion.Data.Access;
using Onion.Data.Account_CoupledClass;


namespace Onion.Repositor.ApplicationContext
{
    public class OnionContext : DbContext
    {
        public OnionContext()
        {

        }
        public OnionContext(DbContextOptions<OnionContext> options) : base(options)
        {

        }
        public DbSet<User> users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRole> userRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=MOJIX-PARIX\\MOJIX_SERVER;Initial Catalog=Onion_Db;Integrated Security=True");
            }
        }
    }


    //public class AppDbContextFactory : IDesignTimeDbContextFactory<OnionContext>
    //{
    //    public OnionContext CreateDbContext(string[] args)
    //    {
    //        var optionsBuilder = new DbContextOptionsBuilder<OnionContext>();
    //        optionsBuilder.UseSqlServer("Data Source=MOJIX-PARIX\\MOJIX_SERVER;Initial Catalog=Onion_Db;Integrated Security=True");
    //        return new OnionContext(optionsBuilder.Options);
    //    }
    //}
}
