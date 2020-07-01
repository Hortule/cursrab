using Microsoft.EntityFrameworkCore;

namespace cursrab3
{
    // выгрузка данных из таблицы Users 
    public class ApplicationContext : DbContext
    { 
        public DbSet<User> Users { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=128.199.53.101;Port=5432;Database=meal_db;Username=postgres;Password='nD6uwE98ydMNhDXndnSy9nRyYNQk9x5x'");
        }
    }
}
