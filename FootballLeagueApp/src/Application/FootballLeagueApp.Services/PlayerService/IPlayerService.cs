using FootballLeagueApp.DTOs.Requests.PlayerRequests;
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
        Task<IEnumerable<PlayerDisplayResponse>> GetAllPlayers();
        Task<IEnumerable<PlayerDisplayResponse>> GetPlayersByNationality(string nationality);
        Task CreatePlayerAsync(CreateNewPlayerRequest createNewPlayerRequest);
    }
}
