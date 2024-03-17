using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using RJ35.Models;
using RJ35.Models.Products;

namespace RJ35.Data;

public class RJ35Context : IdentityDbContext<RJ35WebUser>
{
    public RJ35Context(DbContextOptions<RJ35Context> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // builder.Ignore<IdentityUserClaim<string>>();
        builder.Ignore<IdentityUserRole<string>>();
        builder.Ignore<IdentityRoleClaim<string>>();
        builder.Ignore<IdentityUserLogin<string>>();
        builder.Ignore<IdentityUserToken<string>>();

        builder.Entity<IdentityUserClaim<string>>(entity =>
        {
            entity.ToTable(name: "UserClaims");
        });

        builder.Entity<RJ35WebUser>(entity =>
        {
            entity.ToTable(name: "User");
        });

        builder.Entity<IdentityRole>(entity =>
        {
            entity.Ignore(e => e.NormalizedName);
            entity.Ignore(e => e.ConcurrencyStamp);
            entity.ToTable(name: "UserRoles");
        });

        builder.Entity<Product>(entity =>
        {
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("GETDATE()");
        });

        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }

    
    public DbSet<RJ35.Models.UserNotifications> UserNotifications { get; set; } = default!;
    public DbSet<RJ35.Models.Order> Order { get; set; } = default!;


    // Products
    public DbSet<RJ35.Models.Products.Product> Products { get; set; } = default!;
    public DbSet<RJ35.Models.Products.Cable> Cables { get; set; } = default!;
    public DbSet<RJ35.Models.Products.Device> Devices { get; set; } = default!;
}
