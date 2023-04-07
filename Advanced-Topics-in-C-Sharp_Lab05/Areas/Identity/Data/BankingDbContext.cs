using Advanced_Topics_in_C_Sharp_Lab05.Areas.Identity.Data;
using Advanced_Topics_in_C_Sharp_Lab05.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Advanced_Topics_in_C_Sharp_Lab05.Data;

public class BankingDbContext : IdentityDbContext<ApplicationUser>
{
    public BankingDbContext(DbContextOptions<BankingDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        // Customize the ASP.NET Identity model and override the defaults if needed.
        // For example, you can rename the ASP.NET Identity table names and more.
        // Add your customizations after calling base.OnModelCreating(builder);
    }
    public DbSet<BankAccount> BankAccounts { get; set; }
}
