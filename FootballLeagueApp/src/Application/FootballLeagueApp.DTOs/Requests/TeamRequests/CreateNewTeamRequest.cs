using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Requests.TeamRequests
{
    public class CreateNewTeamRequest
    {
        [Required(ErrorMessage = "Takım Adı Boş Bırakılmamalıdır!")]
        [MinLength(3, ErrorMessage = "Takım Adı En Az 3 Harften Oluşmak Zorundadır!")]
        public string Name { get; set; } = string.Empty;
        [Required(ErrorMessage = "Takım Kuruluş Tarihi Boş Bırakılmamalıdır!")]
        [Range(1, int.MaxValue, ErrorMessage = "Takım Kuruluş Tarihi, 0'dan Büyük Olmak Zorundadır!")]
        public int FoundingDate { get; set; }
        public string? ImageUrl { get; set; } = "https://w7.pngwing.com/pngs/250/929/png-transparent-no-symbol-no-smoking-miscellaneous-text-trademark-thumbnail.png";
        public int? StadiumId { get; set; }
        public int? CoachId { get; set; }
    }
}
