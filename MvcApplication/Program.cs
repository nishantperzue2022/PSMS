using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MvcApplication.BLL.MapperProfiles;
using MvcApplication.BLL.Repositories.MemberModule;
using MvcApplication.BLL.Repositories.MvcModule;
using MvcApplication.BLL.Repositories.SchemeModule;
using MvcApplication.DAL.DbContext;
using MvcApplication.DAL.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddAutoMapper(typeof(MapperProfile));

builder.Services.AddDbContext<ApplicationDbContext>(options =>

options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Transient);

builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

builder.Services.AddTransient<IMvcRepository, MvcRepository>();

builder.Services.AddTransient<ISchemeRepository, SchemeRepository>();

builder.Services.AddTransient<IMemberRepository, MemberRepository>();

var app = builder.Build();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
