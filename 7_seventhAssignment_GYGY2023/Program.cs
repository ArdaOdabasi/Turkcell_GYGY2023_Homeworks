//< --- It was created to explain the Interface Segregation Principle. --->

// Arayüz ayrım prensibi olarak da bilinir.
// Sınıflar, ihtiyaç duymadıkları metotların bulunduğu Interface`lere bağlı olmaya zorlanmamalıdır.

// Çeşitli mesaj tipleri (Email, SMS vb.) göndermek isteyen bir uygulama için IMessage isimli bir interface yarattığımızı varsayalım.

// --- Yanlış Tasarım ---
// Email mesajı gönderecek client için problem yok.
// Imessage üzerindeki tüm üye ve metotlar kullanılıyor.
// Fakat SmsMessage sınıfı "Subject" property`sini kullanmıyor yani burada bir problem var.

// --- Doğru Tasarım ---
// Arayüzleri ayırdım ve INewMessage sınıfındaki "Subject" property`si kaldırdım.
// EmailMessage somut sınıfında INewMessage sınıfından inherit edilerek kullanılan "Subject" property`sinin tekrar inherit edilebilmesi ve de EmailMessage sınıfına ait yeni propertyleri kullanabilmek için IEmailMessage adında bir interface oluşturdum ve de INewMessage interface`sinden inherit ettim.
// EmailMessage somut sınıfı da IEmailMessage interface`inden inherit ettim.

Console.WriteLine("It was created to explain the Interface Segregation Principle.");
