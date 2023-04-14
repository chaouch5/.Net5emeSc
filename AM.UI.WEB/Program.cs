using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using AM.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IServiceFlight, ServiceFlight>();
//IServiceFlight service = new ServiceFlight();
builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();
//IUnitOfWork UOW = new UnitOfWork(DbContext,Type);
builder.Services.AddDbContext<DbContext,AMContext>();
//DbContext dbContext = new AMContext();
builder.Services.AddSingleton<Type>(p => typeof(GenericRepository<>));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
