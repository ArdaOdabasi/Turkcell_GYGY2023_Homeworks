using FootballLeagueApp.DTOs.Requests.MatchRequests;
using FootballLeagueApp.DTOs.Requests.PlayerRequests;
using FootballLeagueApp.DTOs.Responses.MatchResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.MatchService
{
    public interface IMatchService
    {
        Task<IEnumerable<MatchDisplayResponse>> GetAllMatchesAsync();
        Task CreateMatchAsync(CreateNewMatchRequest createNewMatchRequest);
        Task<bool> MatchIsExistsAsync(int matchId);
        Task UpdateMatchAsync(UpdateMatchRequest updateMatchRequest);
        Task<UpdateMatchRequest> GetMatchForUpdate(int id);
    }
}
