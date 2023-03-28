using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_fifthAssignment_GYGY2023
{
    public class UyeKotuKod
    {
        // Bu sınıfta, Tek Sorumluluk Prensibine (Single Responsibility Principle) uyulmaması sağlanmıştır
        // Bu sınıfa gereğinden fazla sorumluluk yüklenmiştir
        // GirisYap, ePostaGonder ve SmsGonder fonksiyonları kohezyonun düşmesine sebep olmuştur

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }

        public void GirisYap()
        {
            Console.WriteLine("Üye sınıfının 'GirisYap' metodu çalıştırılmıştır");
        }

        public void ePostaGonder()
        {
            Console.WriteLine("Üye sınıfının 'ePostaGonder' metodu çalıştırılmıştır");
        }
  
        public void SmsGonder()
        {
            Console.WriteLine("Üye sınıfının 'SmsGonder' metodu çalıştırılmıştır");
        }
    }
}
