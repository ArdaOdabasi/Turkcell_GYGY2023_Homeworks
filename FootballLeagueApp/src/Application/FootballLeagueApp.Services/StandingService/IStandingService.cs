using FootballLeagueApp.DTOs.Requests.StandingRequests;
using FootballLeagueApp.DTOs.Requests.StatisticRequests;
using FootballLeagueApp.DTOs.Responses.StandingResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.StandingService
{
    public interface IStandingService
    {
        Task<IEnumerable<StandingDisplayResponse>> GetAllStandingsAsync();
        Task CreateStandingAsync(CreateNewStandingRequest createNewStandingRequest);
        Task<IEnumerable<StandingDisplayResponse>> GetAllStandingsOrderedByScoreAsync();
        Task<bool> StandingIsExistsAsync(int standingId);
        Task UpdateStandingAsync(UpdateStandingRequest updateStandingRequest);
        Task<UpdateStandingRequest> GetStandingForUpdate(int id);
    }
}
