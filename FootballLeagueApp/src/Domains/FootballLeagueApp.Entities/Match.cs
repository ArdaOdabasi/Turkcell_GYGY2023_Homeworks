using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Entities
{
    public class Match : IEntity
    {
        public int Id { get; set; }
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Result { get; set; } = string.Empty;
        public Team? HomeTeam { get; set; }
        public int? HomeTeamId { get; set; }
        public Team? AwayTeam { get; set; }
        public int? AwayTeamId { get; set; }
        public Stadium? Stadium { get; set; }
        public int? StadiumId { get; set; }
    }
}
