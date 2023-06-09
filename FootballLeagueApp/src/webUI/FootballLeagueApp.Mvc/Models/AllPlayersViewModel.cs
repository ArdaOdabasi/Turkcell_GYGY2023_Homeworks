using FootballLeagueApp.DTOs.Responses.PlayerResponses;
using FootballLeagueApp.DTOs.Responses.StatisticResponses;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.Entities;

namespace FootballLeagueApp.Mvc.Models
{
    public class AllPlayersViewModel
    {
        public IEnumerable<PlayerDisplayResponse> players { get; set; }
        public List<StatisticDisplayResponse> statistics { get; set; }
        public Dictionary<int, string> teamNames { get; set; } 
    }
}
