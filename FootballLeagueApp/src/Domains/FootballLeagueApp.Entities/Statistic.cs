using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Entities
{
    public class Statistic : IEntity
    {
        public int Id { get; set; }
        [Required]
        public int Match { get; set; }
        [Required]
        public int Goal { get; set; }
        [Required]
        public int Assist { get; set; }
        [Required]
        public int YellowCard { get; set; }
        [Required]
        public int RedCard { get; set; }
        public Player? Player { get; set; }
        public int? PlayerId { get; set; }
    }
}
