using FootballLeagueApp.DTOs.Responses.StandingResponses;
using FootballLeagueApp.DTOs.Responses.TeamResponses;

namespace FootballLeagueApp.Mvc.Models
{
    public class AllStandingsViewModel
    {
        public IEnumerable<StandingDisplayResponse> standings { get; set; }
        public List<TeamDisplayResponse> teams { get; set; }
    }
}
