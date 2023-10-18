using Microsoft.EntityFrameworkCore;
using ShoppingAPI23.DAL.Entities;

namespace ShoppingAPI23.DAL
{
    public class DataBaseContext : DbContext
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();
        }

        #region DbSets
        public DbSet<Country> Countries { get; set; }

        #endregion
    }
}
