using Hangfire;
using Using_CronJob_Hangfire.Jobs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// CronJob ile ilgili yapýlandýrmalarýmýzý burada yaparýz.
// Ayrýca CronJob ile ilgili tüm konfigürasyon dosyalarýmýzý saklamamýz gerekli.

var hangfireConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=DbCronJobHangfire;Integrated Security=True;";
// Biz HangFire server için ilgili konfigürasyon dosyalarýmýzý veritabanýnda saklayacaðýz.

// Hangfire ve Hangfire AspNetCore kütüphanelerini projemize ekledik.

builder.Services.AddHangfire(x =>
{
    x.UseSqlServerStorage(hangfireConnectionString); // SqlServer kullanacaðýmýzý belirttik.

    RecurringJob.AddOrUpdate<Job>(j => j.DBControl(), "30 17 * * *");
    // Çok çeþit job türü vardýr. Fakat biz Rekürsif (kendini tekrar eden) olan job türü ile çalýþacaðýz.
    // AddOrUpdate => Bu konfigürasyon yoksa kendisi ekler varsa bu konfigürasyonü günceller.
    // Job`ýn sýnýfýný ve oluþturduðumuz methodun adýný (DbControl) kullanýyoruz.
    // Son olarak cron expression veririz. Cron expression, RecurringJob`ýn nasýl çalýþmasý gerektiðini belirler.

    // Cron expression için "crontab.cronhub.io" sitesinden yararlanýyoruz.
    // "30 17 * * *" -> Her gün 17.30`da çalýþacak

    // Veritabanýný kendisi oluþturmuyor. Tablolarý kendisi oluþturuyor. Bu sebeple veritabanýný oluþtururuz.
});

// Hangfire`i ve konfigürasyonlarýný ekliyoruz.

builder.Services.AddHangfireServer();
// Server`ý oluþturup, ekledik.

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

app.UseAuthorization();

app.UseHangfireDashboard(); 
// Hangfire Dashboard`a sadece uygulamanýn çalýþtýðý yerden eriþiriz. Bu sebeple bu kod satýrýný da ekledik.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
