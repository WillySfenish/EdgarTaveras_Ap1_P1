using EdgarTaveras_Ap1_P1.Components;
using EdgarTaveras_Ap1_P1.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//Getting Connection String
var ConStr = builder.Configuration.GetConnectionString("ConStr");
//Injecting Connection String
builder.Services.AddDbContext<Contexto>(options => options.UseSqlite(ConStr));
//Injecting Service to the Program





// arriba de esto !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
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
