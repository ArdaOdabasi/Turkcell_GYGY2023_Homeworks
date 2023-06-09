using FootballLeagueApp.DTOs.Requests.PlayerRequests;
using FootballLeagueApp.DTOs.Requests.RoleRequests;
using FootballLeagueApp.DTOs.Requests.StatisticRequests;
using FootballLeagueApp.DTOs.Responses.PlayerResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.PlayerService
{
    public interface IPlayerService
    {
        Task<IEnumerable<PlayerDisplayResponse>> GetAllPlayersAsync();
        Task<IEnumerable<PlayerDisplayResponse>> GetPlayersByNationalityAsync(string nationality);
        Task CreatePlayerAsync(CreateNewPlayerRequest createNewPlayerRequest);
        Task<int> CreateAndReturnIdAsync(CreateNewPlayerRequest createNewPlayerRequest);
        Task<int> UpdateAndReturnIdAsync(UpdatePlayerRequest updatePlayerRequest);
        Task UpdateStatisticIdAsync(int playerId, int newStatisticId);
        Task<bool> PlayerIsExistsAsync(int playerId);
        Task UpdatePlayerAsync(UpdatePlayerRequest updatePlayerRequest);
        Task<UpdatePlayerRequest> GetPlayerForUpdate(int id);
        Task DeleteAsync(int id);
    }
}
