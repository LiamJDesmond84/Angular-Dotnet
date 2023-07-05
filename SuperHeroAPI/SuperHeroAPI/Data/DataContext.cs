using Microsoft.EntityFrameworkCore;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        // Adds the SuperHeros table to the SQLServer DB
        public DbSet<SuperHero> SuperHeroes { get; set; }

        //public DbSet<SuperHero> SuperHeroes => Set<SuperHero>();
    }
}
