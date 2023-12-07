
using Microsoft.AspNetCore.Mvc.Controllers;
using Ninject;
using Onion_Architecture.Web.IOC;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();





// Create a new Ninject kernel
//var kernel = new StandardKernel();

//// Register services and dependencies with Ninject
//kernel.Load(new NinjectController());

//// Set Ninject as the service provider
//builder.Services.AddSingleton<IKernel>(kernel);

//builder.Services.Configure<ExceptionHandlerOptions>(options =>
//{
//    options.AllowStatusCode404Response = true;
//});

builder.Services.AddSingleton<IControllerActivator, NinjectController>();


var app = builder.Build();




// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseAuthorization();

//app.MapControllers();
//app.UseHttpsRedirection();
//app.UseExceptionHandler("/Error");
//app.UseHsts();
//app.UseStaticFiles();
app.UseRouting();

//app.UseAuthentication();

//app.UseEndpoints(endpoints =>
//{
//    endpoints.MapControllerRoute(
//        name: "default",
//        pattern: "{controller=Home}/{action=Index}/{id?}");
//});

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
