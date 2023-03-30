//< --- It was created to explain the Dependency Inversion Principle. --->

// Bağımlılığı Ters Çevirme prensibi (Dependency Inversion Principle) yüksek seviyeli sınıfların, düşük seviyeli sınıflarla doğrudan bir bağımlılığının olmamasını öngörmektedir.
// Bağımlılığın artmaması için; yüksek seviyeli sınıflar ile düşük seviyeli sınıfların arasına bir ara yüz ya da soyut sınıf sokulması gerekmektedir.
// Düşük seviyeli sınıflar, uygulamadaki temel işlevleri yerine getirirler.
// Örneğin, stok takip uygulamasında kota bilgilerini alan Finder sınıfı ya da sayfada bu bilgileri göstermeye yarayan Renderer sınıfı gibi sınıf düşük seviyeli sınıflardır.
// Öte yandan bu sınıfları kullanarak çalışan Stock sınıfı ise yüksek seviyeli bir sınıftır.
// Yüksek seviyeli sınıflar aşağı seviyeli sınıfları anlamlı kılarlar.

Console.WriteLine("It was created to explain the Dependency Inversion Principle.");
