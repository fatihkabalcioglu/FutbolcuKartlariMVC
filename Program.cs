using FutbolcuKartlariMVC.Context;
using FutbolcuKartlariMVC.Repositories.Abstract;
using FutbolcuKartlariMVC.Repositories.Concrete;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<AppDbContext>(o => o.UseSqlServer(builder.Configuration.GetConnectionString("ConStr")));

builder.Services.AddTransient<ITakimRepository , TakimRepository>();
builder.Services.AddTransient<IFutbolcuRepository, FutbolcuRepository>();
builder.Services.AddTransient(typeof(IRepository<>), typeof(GenericRepository<>));


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
    pattern: "{controller=Futbolcu}/{action=Index}/{id?}");

app.Run();
