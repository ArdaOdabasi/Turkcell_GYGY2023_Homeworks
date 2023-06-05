using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Entities
{
    public class Player : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public int Age { get; set; }
        [Required]
        public string Position { get; set; } = string.Empty;
        [Required]
        public string Nationality { get; set; } = string.Empty;
        public Team? Team { get; set; }
        public int? TeamId { get; set; }
        public Statistic? Statistic { get; set; }
        public int? StatisticId { get; set; }
    }
}
