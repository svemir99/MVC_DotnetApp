using Microsoft.EntityFrameworkCore;

namespace FirsttMvcApps.Models
{
    public class PeopleContext : DbContext
    {

        public DbSet<Person> People { get; set; }

        public PeopleContext()
        {

        }


        public PeopleContext(DbContextOptions<PeopleContext> options)
            : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Testt;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
