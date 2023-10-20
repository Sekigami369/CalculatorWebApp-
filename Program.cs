using CalculatorWebApp.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddTransient<CalcModel>();

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
    name:"defalt",
    pattern: "{controller=Calc}/{action=CalcView}/{id?}");

app.MapControllerRoute(
    name: "Calculate",
    pattern: "Calc/Calculate",
    //pattern: "{controller=CalcController}/{action=Calculate}",
    defaults: new { Controller = "Calc", action = "Calculate" }
    );

app.Run();
