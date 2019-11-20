using Microsoft.EntityFrameworkCore;
using MvcMovie.Models;


namespace MvcMovie.Data
{
    public class MvcMovieContext : DbContext
    {
        public MvcMovieContext()
        {
        }

        public MvcMovieContext(DbContextOptions<MvcMovieContext> options)
            : base(options)
        {
        }
        
        public DbSet<Product> Product { get; set; }
        public DbSet<Sell> Sell { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sell>()
            .HasOne(s => s.Product)
            .WithMany(p => p.Sell)
            .HasForeignKey(s => s.p_name)
            .HasPrincipalKey(p => p.p_name);
    }
}



    public class AspnetNoteDbContext : DbContext

    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost;Database=AspnetNoteDb;User Id=sa;
Password = 1q2w3e4r; ");
        }

    }
}