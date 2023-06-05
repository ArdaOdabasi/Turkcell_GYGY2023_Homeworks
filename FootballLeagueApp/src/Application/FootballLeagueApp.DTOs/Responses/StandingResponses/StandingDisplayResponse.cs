using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Responses.StandingResponses
{
    public class StandingDisplayResponse
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int Win { get; set; }
        public int Draw { get; set; }
        public int Defeat { get; set; }
        public int GoalsFor { get; set; }
        public int GoalsAgainst { get; set; }
        public int? TeamId { get; set; }
    }
}
