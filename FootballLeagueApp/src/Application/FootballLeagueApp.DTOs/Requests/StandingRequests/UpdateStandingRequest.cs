using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Requests.StandingRequests
{
    public class UpdateStandingRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Puan Boş Bırakılmamalıdır!")]
        [Range(0, int.MaxValue, ErrorMessage = "Puan 0`dan Büyük Olmak Zorundadır!")]
        public int Score { get; set; }
        [Required(ErrorMessage = "Galibiyet Sayısı Boş Bırakılmamalıdır!")]
        [Range(0, int.MaxValue, ErrorMessage = "Galibiyet Sayısı 0`dan Büyük Olmak Zorundadır!")]
        public int Win { get; set; }
        [Required(ErrorMessage = "Beraberlik Sayısı Boş Bırakılmamalıdır!")]
        [Range(0, int.MaxValue, ErrorMessage = "Beraberlik Sayısı 0`dan Büyük Olmak Zorundadır!")]
        public int Draw { get; set; }
        [Required(ErrorMessage = "Mağlubiyet Sayısı Boş Bırakılmamalıdır!")]
        [Range(0, int.MaxValue, ErrorMessage = "Mağlubiyet Sayısı 0`dan Büyük Olmak Zorundadır!")]
        public int Defeat { get; set; }
        [Required(ErrorMessage = "Attığı Gol Sayısı Boş Bırakılmamalıdır!")]
        [Range(0, int.MaxValue, ErrorMessage = "Attığı Gol Sayısı 0`dan Büyük Olmak Zorundadır!")]
        public int GoalsFor { get; set; }
        [Required(ErrorMessage = "Yediği Gol Sayısı Boş Bırakılmamalıdır!")]
        [Range(0, int.MaxValue, ErrorMessage = "Yediği Gol Sayısı 0`dan Büyük Olmak Zorundadır!")]
        public int GoalsAgainst { get; set; }
        [Required(ErrorMessage = "Takım Alanı Boş Bırakılmamalıdır!")]
        public int? TeamId { get; set; }
    }
}
