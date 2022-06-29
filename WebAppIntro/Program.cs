using WebAppIntro.Models.Settings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// 2.adým (Options Pattern)
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));

// www.kariyertech.com
// www.ik.kariyerTech.com
// www.kariyertech.com/ik/user-list

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
  app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();


app.UseEndpoints(endpoints =>
{
  endpoints.MapControllerRoute(
    name: "ik",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
  );
});


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
