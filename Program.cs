using Jdenticon.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Google;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddResponseCompression(options =>
{
    options.EnableForHttps = true;
});

var configuration = builder.Configuration;

var app = builder.Build();

app.UseResponseCompression();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
    app.UseHttpsRedirection();
}


app.UseStaticFiles();
app.UseJdenticon();
app.UseRouting();

app.MapControllerRoute(
    name: "default",
    pattern: "api/{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("about", "about.html");
app.MapFallbackToFile("weather", "weather.html");
app.MapFallbackToFile("cv", "cv.html");
app.MapFallbackToFile("boxboxbox", "boxboxbox.html");
app.MapFallbackToFile("index.html");

app.Run();
