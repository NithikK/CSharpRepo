using Microsoft.EntityFrameworkCore;
using NorthWindMVC.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//constructing the middleware
builder.Services.AddControllersWithViews();//routing table gets created with all the views given
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);//atleast one but not more than one//one instance is preloaded
builder.Services.AddDbContext<NorthwindContext>(options => options.UseSqlServer("name=NWindConnection"));
builder.Services.AddScoped<RepositoryEmployee>();//multi instance
builder.Services.AddScoped<RepositoryOrders>();
builder.Services.AddScoped<RepositoryCustomer>();

var app = builder.Build();//where the builder builds the total bundle
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
