using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Requests.UserRequests
{
    public class CreateNewUserRequest
    {
        [Required(ErrorMessage = "Ad Boş Bırakılmamalıdır!")]
        [MinLength(2, ErrorMessage = "Ad En Az 2 Harften Oluşmak Zorundadır!")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Soyad Boş Bırakılmamalıdır!")]
        [MinLength(2, ErrorMessage = "Soyad En Az 2 Harften Oluşmak Zorundadır!")]
        public string LastName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Kullanıcı Adı Boş Bırakılmamalıdır!")]
        [MinLength(3, ErrorMessage = "Kullanıcı Adı En Az 3 Harften Oluşmak Zorundadır!")]
        public string UserName { get; set; } = string.Empty;
        [Required(ErrorMessage = "Şifre Boş Bırakılmamalıdır!")]
        [MinLength(6, ErrorMessage = "Şifre En Az 6 Harften Oluşmak Zorundadır!")]
        public string Password { get; set; } = string.Empty;
    }
}
