using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Web.Api.Core.Domain.Entities;
using Web.Api.Core.Shared;

namespace Web.Api.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {

        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=players.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           /* restore me to have    data in db
            modelBuilder.Entity<Player>().HasData(new Player("Sidney", "Crosby", 180, 91, new DateTime(1987, 8, 7)) { Id = 1,Created = DateTime.UtcNow});
            modelBuilder.Entity<Player>().HasData(new Player("Connor", "McDavid", 185, 88, new DateTime(1997, 1, 13)) { Id = 2, Created = DateTime.UtcNow });
            modelBuilder.Entity<Player>().HasData(new Player("Auston", "Matthews", 191, 100, new DateTime(1997, 9, 17)) { Id = 3, Created = DateTime.UtcNow });
            modelBuilder.Entity<Player>().HasData(new Player("Patrick", "Kane", 180, 177, new DateTime(1988, 11, 19)) { Id = 4, Created = DateTime.UtcNow });
            modelBuilder.Entity<Player>().HasData(new Player("Drew", "Doughty", 185, 200, new DateTime(1989, 12, 8)) { Id = 5, Created = DateTime.UtcNow });
            modelBuilder.Entity<Player>().HasData(new Player("Erik", "Karlsson", 183, 190, new DateTime(1990, 5, 31)) { Id = 6, Created = DateTime.UtcNow }); 
            */
        }
        
        public DbSet<Player> Players { get; set; }

        public override int SaveChanges()
        {
            AddAuitInfo();
            return base.SaveChanges();
        }

        public async Task<int> SaveChangesAsync()
        {
            AddAuitInfo();
            return await base.SaveChangesAsync();
        }

        private void AddAuitInfo()
        {
            var entries = ChangeTracker.Entries().Where(x => x.Entity is BaseEntity && (x.State == EntityState.Added || x.State == EntityState.Modified));
            foreach (var entry in entries)
            {
                if (entry.State == EntityState.Added)
                {
                    ((BaseEntity)entry.Entity).Created = DateTime.UtcNow;
                }
                ((BaseEntity)entry.Entity).Modified = DateTime.UtcNow;
            }
        }
    }
}
