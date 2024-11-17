using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class AppDbContext : IdentityDbContext<User>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        builder.Entity<IdentityRole>().HasData(
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Owner", NormalizedName = "OWNER" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Administrator", NormalizedName = "ADMINISTRATOR" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "VPCD", NormalizedName = "VPCD" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "BM", NormalizedName = "BM" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "ChannelActivationHead", NormalizedName = "CHANNEL ACTIVATION HEAD" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "ASM", NormalizedName = "ASM" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "BAM", NormalizedName = "BAM" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "CE", NormalizedName = "CE – CAPABILITY EXECUTIVE" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "SaleSUP", NormalizedName = "SALE SUP – SALE SUPERVISOR" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Distributor-OM/TL", NormalizedName = "DISTRIBUTOR - OM/TL" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "OtherDepartment", NormalizedName = "OTHER DEPARTMENT" },
            new IdentityRole { Id = Guid.NewGuid().ToString(), Name = "Guest", NormalizedName = "GUEST" }
        );
    }
}
