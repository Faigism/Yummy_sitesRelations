using Microsoft.EntityFrameworkCore;
using Yummy_RelationsSite_HomeTask_.DAL;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<DB_Context>(opt =>
{
    opt.UseSqlServer("Server=ASUSPROART\\SQLEXPRESS;Database=Yummysite_Relations;Integrated Security=true");
});
var app = builder.Build();

app.MapControllerRoute("default","{controller=Home}/{action=Index}/{id?}");
app.UseStaticFiles();
app.Run();
