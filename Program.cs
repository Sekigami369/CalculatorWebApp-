using CalculatorWebApp.Models;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

    //àÀë∂ê´Çíçì¸ÇµÇƒÇ¢ÇÈ
//builder.Services.AddTransient<CalcModel>();
builder.Services.AddSingleton<CalcModel>();

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
    pattern: "CalcController/Calculate",
    defaults: new { Controller = "CalcController", action = "Calculate" }
    );

app.Run();
