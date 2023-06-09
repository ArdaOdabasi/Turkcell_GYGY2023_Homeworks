using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Requests.MatchRequests
{
    public class UpdateMatchRequest
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tarih ve Saat Alanı Boş Bırakılamaz!")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Sonuç Alanı Boş Bırakılamaz!")]
        [RegularExpression(@"^\d+-\d+$", ErrorMessage = "Geçerli Bir Sonuç Formatı Giriniz! (Örnek: 2-0)")]
        public string Result { get; set; } = string.Empty;
        [Required(ErrorMessage = "Ev Sahibi Takım Alanı Boş Bırakılamaz!")]
        public int HomeTeamId { get; set; }
        [Required(ErrorMessage = "Deplasman Takım Alanı Boş Bırakılamaz!")]
        public int AwayTeamId { get; set; }
        [Required(ErrorMessage = "Stadyum Alanı Boş Bırakılamaz!")]
        public int StadiumId { get; set; }
    }
}
