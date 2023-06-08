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
        [Required]
        public Team HomeTeam { get; set; }
        [Required]
        public int HomeTeamId { get; set; }
        [Required]
        public Team AwayTeam { get; set; }
        [Required]
        public int AwayTeamId { get; set; }
        [Required]
        public Stadium Stadium { get; set; }
        [Required]
        public int StadiumId { get; set; }
    }
}
