
using Microsoft.Extensions.Configuration;
using gasimmoeval.Models;

namespace gasimmoeval.Data
{
    public class AppDbContext : AppDbContext
    {
        protected readonly IConfiguration Configuration;
        internal object _administrateur;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));
        }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public DbSet<Administrateur> _administrateur {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Administrateur>() 
                .Property(p => p.Id)
                .HasDefaultValueSql($"NEXT VALUE FOR administrateur_seq");
        }

        public DbSet<DataImport> dataImport { get; set; }
    }
}