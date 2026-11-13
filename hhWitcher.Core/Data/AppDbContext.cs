using Microsoft.EntityFrameworkCore;
using hhWitcher.Core.Entities;

namespace hhWitcher.Core.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public DbSet<User> Users { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Executor> Executors { get; set; }
    public DbSet<Support> Supports { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Appeal> Appeals { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().ToTable("users");
        modelBuilder.Entity<Customer>().ToTable("users");
        modelBuilder.Entity<Executor>().ToTable("users");
        modelBuilder.Entity<Support>().ToTable("users");

        modelBuilder.Entity<Order>().ToTable("orders");
        modelBuilder.Entity<Review>().ToTable("reviews");
        modelBuilder.Entity<Appeal>().ToTable("appeals");
        
        modelBuilder.Entity<User>()
            .HasDiscriminator<string>("UserType")
            .HasValue<Customer>("Customer")
            .HasValue<Executor>("Executor")
            .HasValue<Support>("Support");

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Customer)
            .WithMany()
            .HasForeignKey(o => o.CustomerId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.Executor)
            .WithMany()
            .HasForeignKey(o => o.ExecutorId)
            .OnDelete(DeleteBehavior.Restrict);
            
        modelBuilder.Entity<Review>()
            .HasOne(r => r.Order)
            .WithMany(o => o.Reviews)
            .HasForeignKey(r => r.OrderId);

        modelBuilder.Entity<Appeal>()
            .HasOne(a => a.User)
            .WithMany()
            .HasForeignKey(a => a.UserId);
    }
}