using FootballLeagueApp.DTOs.Requests.StatisticRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.StatisticResponses;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.StatisticService
{
    public interface IStatisticService
    {
        Task<IEnumerable<StatisticDisplayResponse>> GetAllStatisticsAsync();
        Task<StatisticDisplayResponse> GetStatisticByIdAsync(int id);
        Task CreateStatisticAsync(CreateNewStatisticRequest createNewStatisticRequest);
        Task<int> CreateAndReturnIdAsync(CreateNewStatisticRequest createNewStatisticRequest);
        Task<int> UpdateAndReturnIdAsync(UpdateStatisticRequest updateStatisticRequest);
        Task UpdatePlayerIdAsync(int statisticId, int newPlayerId);
        Task<StatisticDisplayResponse?> GetStatisticByPlayerIdAsync(int playerId);
        Task<bool> StatisticIsExistsAsync(int statisticId);
        Task UpdateStatisticAsync(UpdateStatisticRequest updateStatisticRequest);
        Task<UpdateStatisticRequest> GetStatisticForUpdate(int id);
    }
}
