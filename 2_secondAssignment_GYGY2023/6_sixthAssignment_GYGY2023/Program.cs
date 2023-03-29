//< --- It was created to explain the Open/Closed Principle. --->

// Bu proje, Açık Kapalı Prensibi (Open/Closed Principle) konusunu anlatmak için oluşturulmuştur
// Değişim gerektirmeyen yazılımların ömrünün bittiğini söyleyebiliriz. Kullanıcı beklentileri değiştikçe yazılımlar da değişime uğramaktadır.
// Bu yüzden yazılım sistemi, herhangi bir yerindeki değişimin başka yerlerde de zincirleme değişim gerektirmeyeceği şekilde tasarlanmalı yani esnek olmalıdır.
// Böylece ufak bir değişimde oluşabilecek kargaşa engellenmiş olur. Değişim kargaşasını önlemek için esnemez tasarımlardan uzak durulmalıdır.
// Sistemler gelişime açık, ancak değişime kapalı olmalıdır. Bu prensibe göre, sistemlerdeki değişimleri kodları değiştirerek gerçekleştirmek yerine yeni kod blokları eklenerek yapılması öngörülmektedir.

// <--- Yanlış Tasarım (Açık Kapalı Prensibine Uyulmayan Tasarım) --->
// Yeni bir şekil oluşturmak istediğimizde önce bir sınıf oluşturmamız gerekli.
// Sınıfın "Ciz" methodunu tanımlamamız gerekli.
// Ciz sınıfı içerisindeki enCemberTur sınıfına yeni şekil için enum eklenmeli.
// Ciz sınıfı içerisinde yeni şekil için private bir değişken eklenmeli.
// Ciz sınıfına ait constructor içerisine yeni şekil için gerekli adımlar eklenmeli.
// Ciz sınıfı içerisinde yeni şekile ait Ciz() metodunun çağrılması için private bir metot eklenmeli.
// Ciz sınıfı içerisindeki SekilCiz() metodundaki switch-case`e yeni şekil için bir case daha eklenmeli.

// <--- Doğru Tasarım (Açık Kapalı Prensibine Uyulan Tasarım) --->
// Yeni bir şekil oluşturmak istediğimizde önce bir sınıf oluşturmamız gerekli.
// Yeni şekil için oluşturulan sınıf, Sekil sınıfından inherit edilmeli ve Sekil sınıfının metodunu override etmeli.

Console.WriteLine("It was created to explain the Open/Closed Principle.");
