# HangFire Nedir ve Nasıl Çalışır?
HangFire, .NET tabanlı bir arka plan işler yöneticisidir. Bu kütüphane, planlanmış görevleri, tekrarlayan işleri ve kuyruğa alınmış işleri yönetmek için kullanılır. ASP.NET MVC projelerinde kullanılabildiği gibi genel .NET uygulamalarında da kullanılabilir.

# HangFire'ın Çalışma Mantığı
HangFire, işleri arka planda ve asenkron bir şekilde çalıştırmak için kullanılan bir kuyruk sistemi kullanır. İşler, HangFire sunucusu tarafından yönetilir ve işlerin durumu bir veritabanında saklanır. HangFire sunucusu, planlanmış görevleri ve kuyruğa alınmış işleri izler ve uygun zamanlarda işleri çalıştırır.

# HangFire'ı ASP.NET MVC Projesine Entegre Etme
# HangFire'ın Kurulumu

HangFire'ı ASP.NET MVC projesine entegre etmek için öncelikle HangFire paketini yüklemeniz gerekmektedir. Bu, NuGet Paket Yöneticisi'ni kullanarak veya Package Manager Console'da aşağıdaki komutu çalıştırarak yapılabilir:
Install-Package HangFire

# HangFire'ı Projenize Dahil Etme
HangFire'ı projenize ekledikten sonra, kullanmaya başlamak için aşağıdaki adımları izleyebilirsiniz:

Adım 1: HangFire'ı projeye dahil etme
using Hangfire;
using Hangfire.SqlServer;

Adım 2: HangFire'ı yapılandırma
GlobalConfiguration.Configuration.UseSqlServerStorage("connectionString");

Adım 3: HangFire sunucusunu başlatma
app.UseHangfireServer();

Adım 4: HangFire arayüzünü etkinleştirme
app.UseHangfireDashboard();

# HangFire'ın Kullanımı ve Özellikleri
# Görevleri Tanımlama
HangFire'da görevler, BackgroundJob.Enqueue veya BackgroundJob.Schedule metodunu kullanarak tanımlanır. Enqueue metodu, bir görevi hemen çalıştırmak için kullanılırken, Schedule metodu belirli bir tarih veya süre sonra görevi çalıştırmak için kullanılır.

# Görevleri Kuyruğa Alma
HangFire, yoğun iş yükü altında çalışan bir uygulama için işleri kuyruğa almayı destekler. Görevler otomatik olarak kuyruğa alınır ve HangFire sunucusu tarafından uygun zamanda çalıştırılır.

# HangFire Dashboard
HangFire Dashboard, HangFire'ın yönetici panelidir ve arka planda çalışan işlerinizi izlemenize, yönetmenize ve çalıştırmanıza olanak sağlar. Dashboard'a /hangfire URL'sini kullanarak erişebilirsiniz.

# Özellikler
HangFire, parametrelerle çalışabilen görevlerin tanımlanması, tekrarlayan işlerin planlanması, gecikmiş görevlerin çalıştırılması ve hata yönetimi gibi birçok özelliği destekler. Ayrıca, zengin bir API'ye sahiptir ve çeşitli senaryolara uygun esneklik sunar.

# Sonuç
HangFire, ASP.NET MVC projelerinde arka planda çalışan işleri yönetmek için kullanışlı ve güçlü bir araçtır. Basit kullanımı ve zengin özellikleri sayesinde iş yükünü azaltmanıza ve uygulama performansını artırmanıza yardımcı olur.

# Proje Ekran Görüntüleri
![Hangfire1](https://github.com/ArdaOdabasi/Turkcell_GYGY2023_Homeworks/assets/61662021/fdc884d6-cf05-4945-ae27-2bb0f0c52584)

![Hangfire2](https://github.com/ArdaOdabasi/Turkcell_GYGY2023_Homeworks/assets/61662021/67af4bbc-2afd-4e5b-8bde-441a365a5fe0)




