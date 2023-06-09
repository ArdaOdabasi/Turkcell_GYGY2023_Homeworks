using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Requests.StadiumRequests
{
    public class UpdateStadiumRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Stadyum Adı Boş Bırakılmamalıdır!")]
        [MinLength(3, ErrorMessage = "Stadyum Adı En Az 3 Harften Oluşmak Zorundadır!")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Kapasite Boş Bırakılmamalıdır!")]
        [Range(1000, int.MaxValue, ErrorMessage = "Kapasite 1.000'den Büyük Olmak Zorundadır!")]
        public int Capacity { get; set; }
        [Required(ErrorMessage = "Adres Boş Bırakılmamalıdır!")]
        [MinLength(3, ErrorMessage = "Adres En Az 3 Harften Oluşmak Zorundadır!")]
        public string Address { get; set; } = string.Empty;
        public int? TeamId { get; set; }
    }
}
