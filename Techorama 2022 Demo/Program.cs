using Microsoft.AspNetCore.Mvc.RazorPages;
using SV.Techorama.Services;
using SV.Techorama.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<RazorPagesOptions>(options => options.RootDirectory = "/Components/Pages");
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddHttpClient();
builder.Services.AddTransient<IRdwService, RdwService>();

builder.Services.AddFluxor(o =>
{
    o.ScanAssemblies(typeof(Program).Assembly);
    o.UseReduxDevTools(rdt =>
    {
        rdt.Name = "Techorama Demo";
    });
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

app.Run();
