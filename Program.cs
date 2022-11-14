//using System.Management.Automation;
using CliWrap;
using CliWrap.Buffered;
using Contentful.AspNetCore;
using Contentful.Core;
using Contentful.Core.Models;
using Newtonsoft.Json;
using Project.Models;
using System;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddContentful(builder.Configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// CALL THE METHOD IN THE CLASS ManageData
ManageData manageData = new ManageData();
//manageData.Make_Content_Type();


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();