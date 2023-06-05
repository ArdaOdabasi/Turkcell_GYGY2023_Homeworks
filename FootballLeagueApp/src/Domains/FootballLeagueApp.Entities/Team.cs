using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Entities
{
    public class Team : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        [Required]
        public int FoundingDate { get; set; }
        public string? ImageUrl { get; set; }
        public Stadium? Stadium { get; set; }
        public int? StadiumId { get; set; }
        public Coach? Coach { get; set; }
        public int? CoachId { get; set; }
        public ICollection<Player>? Players { get; set; }
        public ICollection<Match>? HomeMatches { get; set; }
        public ICollection<Match>? AwayMatches { get; set; }
    }
}
