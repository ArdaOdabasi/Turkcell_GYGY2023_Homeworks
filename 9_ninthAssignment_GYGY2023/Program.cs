/*
 * Kişilerin kiraladığı veya rezerve ettiği sistemler var. 
 * Ama araç kiralama rezervasyonu ile otel rezervasyonu farklı eylemlerdir.
 * Rezervasyonların tamamında validasyon sistemi yürütülür fakat bu iki durumun validasyonları birbirlerinden farklıdır.
 * Otel odasında kişi sayısı validasyonda önemsiz fakat toplantı validasyonunda önemli.
 * Çünkü otelin 2 adet büyük toplantı salonu var. 
 * Bir tanesi 500 diğeri ise 100 kişilik bir toplantı salonudur.
 * 100 kişilik olan toplantı salonunda "U" yerleşimi var fakat 500 kişilik olan toplantı salonunda "sinema" yerleşimi var.
 * Yani validasyonları bambaşka olmalı.
 * Otel odası veya seminer salonu varlıklarından bir tanesi oluşturulmuş ve ona göre bir validasyon sistemi inşa edilmiş.
 * Fakat bu iki varlığın validasyonları birbirlerinden farklı olduğu için yazılımcı yanılmış ve validasyondan geçmemesi gereken obje geçmiş.
 * Normalde kişinin odayı tutamaması lazım iken özellikle seminer salonunu tutamaması gerekirken validasyon yakalayamıyor.
 * Varlıklar: Araç Kiralama Rezervasyonu / Otel Odası Rezervasyonu / Seminer ve Toplantı Salonu Rezervasyonu
 * Bu varlıkların arasında miras yok sadece valide etme durumu var.
 * Ortak olan özellikleri, tarih ve kaç günlüğüne rezerve edildiğidir.
 */

Console.WriteLine("It was created to explain the Liskov Substitution Principle.");



