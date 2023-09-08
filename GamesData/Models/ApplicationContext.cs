using GameBlocApi.Models.Entity;
using Microsoft.EntityFrameworkCore;

namespace GamesData.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Game> Games { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseNpgsql("Host=localhost;Port=5432;Database=GameDataDb;Username=postgres;Password=1234567");
        }
    }
}
