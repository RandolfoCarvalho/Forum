using Microsoft.EntityFrameworkCore;
using Forum.Data;
using Forum.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//bd connection
var connection = builder.Configuration["ConnectionStrings:DefaultConnection"];
builder.Services.AddDbContext<MySqlContext>(options => options.UseMySql(connection,
    new MySqlServerVersion(
        new Version(8, 0, 0))));

//indejcao de dependencias
builder.Services.AddScoped<PostService>();

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
