using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Entities
{
    public class Standing : IEntity
    {
        public int Id { get; set; }
        [Required]
        public int Score { get; set; }
        [Required]
        public int Win { get; set; }
        [Required]
        public int Draw { get; set; }
        [Required]
        public int Defeat { get; set; }
        [Required]
        public int GoalsFor { get; set; }
        [Required]
        public int GoalsAgainst { get; set; }
        [Required]
        public Team Team { get; set; }
        [Required]
        public int TeamId { get; set; }
    }
}
