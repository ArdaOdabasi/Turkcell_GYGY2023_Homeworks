using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Requests.PlayerRequests
{
    public class CreateNewPlayerRequest
    {
        [Required(ErrorMessage = "Ad Boş Bırakılmamalıdır!")]
        [MinLength(2, ErrorMessage = "Ad En Az 2 Harften Oluşmak Zorundadır!")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Soyad Boş Bırakılmamalıdır!")]
        [MinLength(2, ErrorMessage = "Soyad En Az 2 Harften Oluşmak Zorundadır!")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Yaş Boş Bırakılmamalıdır!")]
        [Range(15, int.MaxValue, ErrorMessage = "Yaş 15'den Büyük Olmak Zorundadır!")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Pozisyon Boş Bırakılmamalıdır!")]
        [MinLength(2, ErrorMessage = "Pozisyon En Az 5 Harften Oluşmak Zorundadır!")]
        public string Position { get; set; } = string.Empty;
        [Required(ErrorMessage = "Uyruk Boş Bırakılmamalıdır!")]
        [MinLength(3, ErrorMessage = "Uyruk En Az 3 Harften Oluşmak Zorundadır!")]
        public string Nationality { get; set; } = string.Empty;
        public int? TeamId { get; set; }
        public int? StatisticId { get; set; }
    }
}
