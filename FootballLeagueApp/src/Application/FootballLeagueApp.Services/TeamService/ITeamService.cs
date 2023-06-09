using FootballLeagueApp.DTOs.Requests.PlayerRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Requests.UserRequests;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.TeamService
{
    public interface ITeamService
    {
        Task<IEnumerable<TeamDisplayResponse>> GetAllTeamsAsync();
        Task<IEnumerable<TeamDisplayResponse?>> GetTeamsWithoutStadiumAsync();
        Task<TeamDisplayResponse> GetTeamByIdAsync(int id);
        Task CreateTeamAsync(CreateNewTeamRequest createNewTeamRequest);
        Task<IEnumerable<TeamDisplayResponse>> GetTeamsWithoutCoachAsync();
        Task UpdateStadiumIdAsync(int teamId, int newStadiumId);
        Task<int> CreateAndReturnIdAsync(CreateNewTeamRequest createNewTeamRequest);
        Task<int> UpdateAndReturnIdAsync(UpdateTeamRequest updateTeamRequest);
        Task UpdateCoachIdAsync(int teamId, int newCoachId);
        Task AddPlayerToTeam(CreateNewPlayerRequest createNewPlayerRequest);
        Task<bool> TeamIsExistsAsync(int teamId);
        Task UpdateTeamAsync(UpdateTeamRequest updateTeamRequest);
        Task<UpdateTeamRequest> GetTeamForUpdate(int id);
        Task DeleteAsync(int id);
    }
}
