using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using StianProsjektAPI.Data;
using StianProsjektAPI.Services;
using StianProsjektOppgave.Data;
using Microsoft.EntityFrameworkCore;
using StianProsjektOppgave.Areas.Identity.Data;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();


builder.Services.AddHttpClient("MyClient", client =>
{
    client.BaseAddress = new Uri("https://localhost:7241");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.UseAuthentication();;

app.Run();
