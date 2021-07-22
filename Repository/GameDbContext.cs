using Microsoft.EntityFrameworkCore;
using MyMicroservice.Model;

namespace MyMicroservice.Repository
{

    public class GameDbContext: DbContext
    {
        public DbSet<Game> Game {get; set;}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=CatalogDB;");
        }

    }
}