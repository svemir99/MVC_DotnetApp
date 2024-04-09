using FirsttMvcApps.Models;
using Microsoft.EntityFrameworkCore;


using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileSystemGlobbing.Internal.Patterns;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;
using Microsoft.AspNetCore.Mvc.Razor;
using FirsttMvcApps;
using Microsoft.CodeAnalysis;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "MyAllowedOrigins",
    builder =>
    {
        builder.WithOrigins("http://localhost:4200");
    });
});


builder.Services.AddResponseCaching();



string connectionString = builder.Configuration.GetConnectionString("PrimaryConnectionString");



    builder.Services.AddDbContext<PeopleContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("PrimaryConnectionString")));



builder.Services.AddControllersWithViews();



    var app = builder.Build();




app.UseCors(option => option.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

    app.UseResponseCaching();



    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.  app.UseHsts();

}

app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();
    app.UseAuthentication(); ;

    app.UseAuthorization();




    app.MapControllerRoute(
    name: "attendant",
    pattern: "attendant/{firstName}-{lastName}",
    defaults: new
    {

        controller = "Home",
        action = "AttendantDetails"

    });

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}/{*slug}");



    app.Run();
