/*
 * Girilen Şifrenin Zayıf-Orta-Güçlü Olduğunu Tespit Eden Konsol Uygulaması
 * 1. Şifre en az 6 karaktarden oluşmalıdır.
 * 2. Şifre sadece harflerden veya sadece sayılardan veya sadece alfanümerik olmayan karakterlerden oluşuyor ise zayıf şifredir.
 * 3. Şifre hem harflerden hem de sayılardan oluşuyor ise orta şifredir.
 * 4. Şifre hem harflerden hem de alfanümerik olmayan karakterlerden oluşuyor ise orta şifredir.
 * 5. Şifre hem sayılardan hem de alfanümerik olmayan karakterlerden oluşuyor ise orta şifredir.
 * 6. Şifre hem harflerden hem sayılardan hem de alfanümerik olmayan karakterlerden oluşuyor ise güçlü şifredir.
 */

Console.Write("\n*** Girilen Şifrenin Zayıf-Orta-Güçlü Olduğunu Tespit Eden Konsol Uygulaması ***\n");
string password = "";

while (password != "ÇIKIŞ")
{
    Console.Write("\n Lütfen bir şifre giriniz ( Şifre Giriş Uygulamasından Çıkış Yapmak İstiyorsanız 'ÇIKIŞ' Yazın Ve Enter Tuşuna Basın ) :  ");
    password = Console.ReadLine();

    if (password == "ÇIKIŞ")
    {
        break;
    }

    if (password.Length < 6)
    {
        Console.WriteLine("\n Şifreniz en az 6 karakterden oluşmak zorundadır!");
    }

    else
    {
        bool onlyLetter = true; // "password" değişkeninin sadece harf karakterlerinden oluşup oluşmadığının bilgisini tutmak için onlyLetter değişkenini oluşturdum.
        bool onlyDigit = true;  // "password" değişkeninin sadece sayı karakterlerinden oluşup oluşmadığının bilgisini tutmak için onlyDigit değişkenini oluşturdum.
        bool onlyNonAlphanumeric = true;   // "password" değişkeninin sadece alfanümerik olmayan karakterlerden oluşup oluşmadığının bilgisini tutmak için onlyNonAlphanumeric değişkenini oluşturdum.

        bool hasLetter = password.Any(char.IsLetter); // "password" değişkeninin en az bir harf karakterine sahip olup olmadığını kontrol etmek için "Any" metodunu kullandım.
        bool hasDigit = password.Any(char.IsDigit); // "password" değişkeninin en az bir sayı karakterine sahip olup olmadığını kontrol etmek için "Any" metodunu kullandım.
        bool hasNonAlphanumeric = password.Any(c => !char.IsLetterOrDigit(c)); // "password" değişkeninin en az bir alfanümerik olmayan karaktere sahip olup olmadığını kontrol etmek için "Any" metodunu kullandım.

        foreach (char character in password)
        {
            if (char.IsLetter(character))
            {
                onlyDigit = false;
                onlyNonAlphanumeric = false;
            }

            else if (char.IsDigit(character))
            {
                onlyLetter = false;
                onlyNonAlphanumeric = false;
            }

            else
            {
                onlyLetter = false;
                onlyDigit = false;
            }
        }

        if (onlyLetter)
        {
            Console.WriteLine("\n Girdiğiniz Şifre 'Zayıf' Bir Şifredir.");
        }

        else if (onlyDigit)
        {
            Console.WriteLine("\n Girdiğiniz Şifre 'Zayıf' Bir Şifredir.");
        }

        else if (onlyNonAlphanumeric)
        {
            Console.WriteLine("\n Girdiğiniz Şifre 'Zayıf' Bir Şifredir.");
        }

        else if (hasLetter && hasDigit && hasNonAlphanumeric)
        {
            Console.WriteLine("\n Girdiğiniz Şifre 'Güçlü' Bir Şifredir.");
        }

        else
        {
            Console.WriteLine("\n Girdiğiniz Şifre 'Orta' Bir Şifredir.");
        }
    }
}

Console.Write("\n Girilen Şifrenin Zayıf-Orta-Güçlü Olduğunu Tespit Eden Konsol Uygulamasından Çıkış Yaptınız!\n");