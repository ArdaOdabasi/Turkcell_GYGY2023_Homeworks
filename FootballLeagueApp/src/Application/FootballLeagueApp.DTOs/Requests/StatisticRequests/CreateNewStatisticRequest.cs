using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Requests.StatisticRequests
{
    public class CreateNewStatisticRequest
    {
        [Required(ErrorMessage = "Maç Sayısı Boş Bırakılmamalıdır!")]
        [Range(0, int.MaxValue, ErrorMessage = "Maç Sayısı 0`dan Büyük Olmak Zorundadır!")]
        public int Match { get; set; }
        [Required(ErrorMessage = "Gol Sayısı Boş Bırakılmamalıdır!")]
        [Range(0, int.MaxValue, ErrorMessage = "Gol Sayısı 0`dan Büyük Olmak Zorundadır!")]
        public int Goal { get; set; }
        [Required(ErrorMessage = "Asist Sayısı Boş Bırakılmamalıdır!")]
        [Range(0, int.MaxValue, ErrorMessage = "Asist Sayısı 0`dan Büyük Olmak Zorundadır!")]
        public int Assist { get; set; }
        [Required(ErrorMessage = "Sarı Kart Sayısı Boş Bırakılmamalıdır!")]
        [Range(0, int.MaxValue, ErrorMessage = "Sarı Kart Sayısı 0`dan Büyük Olmak Zorundadır!")]
        public int YellowCard { get; set; }
        [Required(ErrorMessage = "Kırmızı Kart Sayısı Boş Bırakılmamalıdır!")]
        [Range(0, int.MaxValue, ErrorMessage = "Kırmızı Kart Sayısı 0`dan Büyük Olmak Zorundadır!")]
        public int RedCard { get; set; }
        public int? PlayerId { get; set; }
    }
}
