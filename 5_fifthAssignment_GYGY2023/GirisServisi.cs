using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_fifthAssignment_GYGY2023
{
    public static class GirisServisi
    {
        // Static bir DBEntityContainer`a ihtiyaç var

        public static bool KullaniciDogrula(string kullaniciAdi, string sifre)
        {
            return true;
        }

        public static Uye GirisYap(string kullaniciAdi, string sifre)
        {
            // Kullanıcı Doğrulama İşlemleri
            if (KullaniciDogrula(kullaniciAdi, sifre))
                return new Uye(kullaniciAdi);
            else
                return null;
        }
    }
}
