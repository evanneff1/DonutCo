using DonutCo.Components;
using Microsoft.EntityFrameworkCore;
using Radzen;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddRadzenComponents();

// builder.Services.AddDbContext<DonutContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("RdsDatabase")));
builder.Services.AddDbContext<DonutContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("RdsDatabase"),
        new MySqlServerVersion(new Version(8, 0, 39)))); // Use your MySQL server version here


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();