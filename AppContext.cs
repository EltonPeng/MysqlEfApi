using Microsoft.EntityFrameworkCore;
using mysqlEfApi.Models;

namespace mysqlEfApi
{
    public class AppContext : DbContext
    {
        public DbSet<HistoryRecord> History { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("host=mysql-local;port=3306;database=test;user=dev;password=dev");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HistoryRecord>(entity => 
            {
                entity.HasKey(e => e.UserId);
            });

            modelBuilder.Entity<RecordLine>(entity => {
                entity.HasKey(e => e.Index);
                entity.Property(e => e.Token).HasMaxLength(20);
                entity.Property(e => e.Finished).IsRequired(true);
            });
        }
    }
}