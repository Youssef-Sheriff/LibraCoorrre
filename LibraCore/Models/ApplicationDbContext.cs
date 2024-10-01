using Microsoft.EntityFrameworkCore;

namespace LibraCore.Models;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; } = null!;
    public DbSet<Member> Members { get; set; } = null!;
    public DbSet<Checkout> Checkouts { get; set; } = null!;
    public DbSet<Penalty> Penalties { get; set; } = null!;
    public DbSet<Return> Returns { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Index for Book Title
        modelBuilder.Entity<Book>()
            .HasIndex(b => b.Title);

        // Index for Member Email
        modelBuilder.Entity<Member>()
            .HasIndex(m => m.Email)
            .IsUnique();


        // Index for Checkout MemberId and BookId
        modelBuilder.Entity<Checkout>()
            .HasIndex(c => new { c.MemberId, c.BookId });
    }
}
