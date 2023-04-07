using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Advanced_Topics_in_C_Sharp_Lab05.Data;
using Advanced_Topics_in_C_Sharp_Lab05.Areas.Identity.Data;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Advanced_Topics_in_C_Sharp_Lab05Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Advanced_Topics_in_C_Sharp_Lab05Context") ?? throw new InvalidOperationException("Connection string 'Advanced_Topics_in_C_Sharp_Lab05Context' not found.")));
var connectionString = builder.Configuration.GetConnectionString("Advanced_Topics_in_C_Sharp_Lab05ContextConnection") ?? throw new InvalidOperationException("Connection string 'Advanced_Topics_in_C_Sharp_Lab05ContextConnection' not found.");

builder.Services.AddDbContext<BankingDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = false)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<BankingDbContext>();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
