
/* Install-Package Microsoft.EntityFrameworkCore
 * Install-Package Microsoft.EntityFrameworkCore.SqlServer
 * Install-Package Microsoft.EntityFrameworkCore.Tools
 * 
 * Scaffold-DBContext "Server=BEAST\SQLEXPRESS; Database=CLIENTES;Trusted_Connection=true;MultipleActiveResultSets=true" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
*/
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;
using ClassLibrary1;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<CLIENTESContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

builder.Services.AddDbContext<CLContext>(options =>
  options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

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
