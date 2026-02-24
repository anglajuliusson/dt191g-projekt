using Projektuppgift.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); // Aktivera MVC

builder.Services.AddDbContext<ApplicationDbContext>(options => 
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultDbString"))
);

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
