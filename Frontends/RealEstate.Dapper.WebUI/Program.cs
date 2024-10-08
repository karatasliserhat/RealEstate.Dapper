using RealEstate.Dapper.WebUI.ServiceRegitiration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddServiceRegister(builder.Configuration);

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(

    name: "advert",
    pattern: "property/{slug}/{id}",
        defaults: new { controller = "Advert", action = "PropertyAdvert" });

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(

    name: "areas",
      pattern: "{area:exists}/{controller=AdminDefault}/{action=Index}/{id?}");
app.MapControllerRoute(

    name: "areas",
      pattern: "{area:exists}/{controller=EstateAgentDefault}/{action=Index}/{id?}");

app.Run();
