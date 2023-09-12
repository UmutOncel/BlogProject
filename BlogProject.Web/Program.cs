using BlogProject.DAL.Concrete;
using BlogProject.BLL.Services.Concrete;
using BlogProject.DAL.Entities;
using Microsoft.AspNetCore.Identity;
using BlogProject.DAL.Concrete.Context;
using BlogProject.BLL.Describers;
using BlogProject.Web.Filters.ArticleVisitors;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSession();      //Session i�in eklendi.

// Add services to the container.
builder.Services.AddControllersWithViews(o => 
{
    o.Filters.Add<ArticleVisitorFilter>();  //T�klanma say�s� i�in yapt���m�z filter'� ekledik.
});

builder.Services.AddScopedDAL();    //EFContextDAL'�n dependency injection i�lemi yap�lm�� oldu.
builder.Services.AddScopedBLL();

builder.Services.AddIdentity<AppUser, AppRole>
    (
        //options =>
        //{   // ****KALDIRACA�IZ
        //    options.Password.RequireNonAlphanumeric = false;   //deneme a�amas�nda �ifreyi 1234 gibi girmek i�in
        //    options.Password.RequireLowercase = false;
        //    options.Password.RequireUppercase = false;
        //}
    )
    .AddRoleManager<RoleManager<AppRole>>()
    .AddErrorDescriber<CustomIdentityErrorDescriber>()
    .AddEntityFrameworkStores<AppIdentityContext>()
    .AddDefaultTokenProviders();

builder.Services.ConfigureApplicationCookie(config => 
{                                   //area - control - action
    config.LoginPath = new PathString("/Admin/Authorize/Login");    //Giri� yap�lmazsa, kullan�c� linki bilse dahi bizi login sayfas�na y�nlendirecek.
    config.LogoutPath = new PathString("/Admin/Authorize/Logout");
    config.Cookie = new CookieBuilder 
    { 
        Name = "BlogProject",
        HttpOnly = true,
        SameSite = SameSiteMode.Strict,
        SecurePolicy = CookieSecurePolicy.SameAsRequest    //SameAsRequest: Hem HTTP hem de HTTPS sayfalar�n� destekler. Proje canl�ya ��karsa buray� "Always" yapmam�z gerekir.
    };
    config.SlidingExpiration = true;
    config.ExpireTimeSpan = TimeSpan.FromDays(5);
    config.AccessDeniedPath = new PathString("/Admin/Authorize/AccessDenied");   //Yetkisiz giri�ler bu sayfaya y�nlendirilecek.
});

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

app.UseSession();           //Session kullanmak i�in.

app.UseRouting();

app.UseAuthentication();    //Her zaman "Authorization" �st�nde olur. Kimsin sen?
app.UseAuthorization();     //Rol ile ilgili. Ne i� yapars�n?

app.UseEndpoints(endpoints =>
{
    endpoints.MapAreaControllerRoute
    (
        name: "Admin",
        areaName: "Admin", pattern: "Admin/{Controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapControllerRoute
    (
        name: "default", pattern: "{controller=Home}/{action=About}/{id?}"
    );

    endpoints.MapDefaultControllerRoute();
});

app.Run();
