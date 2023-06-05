using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Responses.MatchResponses
{
    public class MatchDisplayResponse
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Result { get; set; } = string.Empty;
        public int? HomeTeamId { get; set; }
        public int? AwayTeamId { get; set; }
        public int? StadiumId { get; set; }
    }
}
