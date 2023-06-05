using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Responses.TeamResponses
{
    public class TeamDisplayResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int FoundingDate { get; set; }
        public string? ImageUrl { get; set; }
    }
}
