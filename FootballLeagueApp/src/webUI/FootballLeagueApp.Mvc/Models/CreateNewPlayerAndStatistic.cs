using FootballLeagueApp.DTOs.Requests.PlayerRequests;
using FootballLeagueApp.DTOs.Requests.StatisticRequests;

namespace FootballLeagueApp.Mvc.Models
{
    public class CreateNewPlayerAndStatistic
    {
        public CreateNewPlayerRequest createNewPlayerRequest { get; set; }
        public CreateNewStatisticRequest createNewStatisticRequest { get; set; }
    }
}
