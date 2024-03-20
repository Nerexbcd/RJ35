using Microsoft.EntityFrameworkCore;
using RJ35.Data;
using RJ35.Models;
using RJ35.Services;
using Microsoft.AspNetCore.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<RJ35Context>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RJ35Context") ?? throw new InvalidOperationException("Connection string 'RJ35Context' not found."))); 
builder.Services.AddIdentityCore<RJ35WebUser>().AddEntityFrameworkStores<RJ35Context>().AddSignInManager().AddDefaultTokenProviders();

builder.Services.AddAuthentication(o =>
        {
            o.DefaultScheme = IdentityConstants.ApplicationScheme;
            o.DefaultSignInScheme = IdentityConstants.ExternalScheme;
        }).AddIdentityCookies(o => { });

builder.Services.ConfigureApplicationCookie(options =>
            {
                options.AccessDeniedPath = "/access-denied";
                options.LoginPath = "/authentication/login";
                options.LogoutPath = "/authentication/logout";
            });

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession();

builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.UseStatusCodePagesWithReExecute("/home/statuspage/{0}");

app.Run();
