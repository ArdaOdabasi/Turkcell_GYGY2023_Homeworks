using Hangfire;
using Using_CronJob_Hangfire.Jobs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// CronJob ile ilgili yap�land�rmalar�m�z� burada yapar�z.
// Ayr�ca CronJob ile ilgili t�m konfig�rasyon dosyalar�m�z� saklamam�z gerekli.

var hangfireConnectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=DbCronJobHangfire;Integrated Security=True;";
// Biz HangFire server i�in ilgili konfig�rasyon dosyalar�m�z� veritaban�nda saklayaca��z.

// Hangfire ve Hangfire AspNetCore k�t�phanelerini projemize ekledik.

builder.Services.AddHangfire(x =>
{
    x.UseSqlServerStorage(hangfireConnectionString); // SqlServer kullanaca��m�z� belirttik.

    RecurringJob.AddOrUpdate<Job>(j => j.DBControl(), "30 17 * * *");
    // �ok �e�it job t�r� vard�r. Fakat biz Rek�rsif (kendini tekrar eden) olan job t�r� ile �al��aca��z.
    // AddOrUpdate => Bu konfig�rasyon yoksa kendisi ekler varsa bu konfig�rasyon� g�nceller.
    // Job`�n s�n�f�n� ve olu�turdu�umuz methodun ad�n� (DbControl) kullan�yoruz.
    // Son olarak cron expression veririz. Cron expression, RecurringJob`�n nas�l �al��mas� gerekti�ini belirler.

    // Cron expression i�in "crontab.cronhub.io" sitesinden yararlan�yoruz.
    // "30 17 * * *" -> Her g�n 17.30`da �al��acak

    // Veritaban�n� kendisi olu�turmuyor. Tablolar� kendisi olu�turuyor. Bu sebeple veritaban�n� olu�tururuz.
});

// Hangfire`i ve konfig�rasyonlar�n� ekliyoruz.

builder.Services.AddHangfireServer();
// Server`� olu�turup, ekledik.

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
// Hangfire Dashboard`a sadece uygulaman�n �al��t��� yerden eri�iriz. Bu sebeple bu kod sat�r�n� da ekledik.

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
