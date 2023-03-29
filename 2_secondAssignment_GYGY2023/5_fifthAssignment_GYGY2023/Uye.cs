using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_fifthAssignment_GYGY2023
{
    public class Uye
    {
        // Bu sınıfta, Tek Sorumluluk Prensibine (Single Responsibility Principle) uyulması sağlanmıştır
        // Bu sınıfa gereğinden fazla sorumluluk yüklenmemiştir. Uye sınıfı gereksiz sorumluluklardan arındırılarak sadece belirli görevleri yerine getirmek üzere yeniden tasarlanmıştır
        // Uye sınıfının gereksiz sorumlulukların arındırılması için e-posta metodlarının bir araya getirildiği ePostaUtil sınıfı oluşturulmuştur
        // Uye sınıfının gereksiz sorumlulukların arındırılması için sms metodlarının bir araya getirildiği SmsUtil sınıfı oluşturulmuştur
        // Uye sınıfının gereksiz sorumlulukların arındırılması için giriş metodlarının bir araya getirildiği GirisServisi sınıfı oluşturulmuştur

        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string Eposta { get; set; }

        public Uye(string KullaniciAdi) 
        { 
            this.KullaniciAdi= KullaniciAdi;
        }    
    }
}
