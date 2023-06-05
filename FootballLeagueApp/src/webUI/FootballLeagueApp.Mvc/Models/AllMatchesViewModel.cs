using FootballLeagueApp.DTOs.Responses.MatchResponses;
using FootballLeagueApp.DTOs.Responses.StadiumResponses;
using FootballLeagueApp.DTOs.Responses.StatisticResponses;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.Entities;

namespace FootballLeagueApp.Mvc.Models
{
    public class AllMatchesViewModel
    {
        public IEnumerable<MatchDisplayResponse> matches { get; set; }
        public List<TeamDisplayResponse> homeTeams { get; set; }
        public List<TeamDisplayResponse> awayTeams { get; set; }
        public List<StadiumDisplayResponse> stadiums { get; set; }
    }
}
