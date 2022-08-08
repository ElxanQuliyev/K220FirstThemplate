using Microsoft.EntityFrameworkCore;

namespace K220FirstThemplate.Models
{
    public class ButenDbContext:DbContext
    {
        public DbSet<Section1> Section1s { get; set; }
        public DbSet<Section2> Section2s { get; set; }

        public ButenDbContext()
        {

        }
        public ButenDbContext(DbContextOptions opt):base(opt)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-8QJDLB6;Initial Catalog=ButenDB;Trusted_connection=true");
            }
        }
    }
}
