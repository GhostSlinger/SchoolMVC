using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);



// What I add: Add services to the container.
builder.Services.AddDbContext<WebSchoolAppContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString(nameof(WebSchoolAppContext)));

    // Enable lazy loading
    options.UseLazyLoadingProxies();
});



// Default already added: Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();


// Seed data.
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        SeedData.Initialize(services);
    }
    catch (Exception ex)
    {
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "An error occurred seeding the DB.");
    }
}




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
//app.UseStatusCodePages();       // 404 page
app.UseRouting();
app.UseAuthorization();
//app.UseSession();           // Enable sessions.


// This actually does the same thing home index
app.MapDefaultControllerRoute();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
