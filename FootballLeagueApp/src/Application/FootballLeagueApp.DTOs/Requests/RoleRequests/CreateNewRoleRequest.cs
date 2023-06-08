using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Requests.RoleRequests
{
    public class CreateNewRoleRequest
    {
        [Required(ErrorMessage = "Rol Adı Boş Bırakılmamalıdır!")]
        [MinLength(3, ErrorMessage = "Rol Adı En Az 3 Harften Oluşmak Zorundadır!")]
        public string Name { get; set; } = string.Empty;
    }
}
