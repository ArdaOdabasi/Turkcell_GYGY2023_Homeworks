using FootballLeagueApp.DTOs.Requests.StadiumRequests;
using FootballLeagueApp.DTOs.Requests.StandingRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.CoachResponses;
using FootballLeagueApp.DTOs.Responses.StadiumResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.StadiumService
{
    public interface IStadiumService
    {
        Task<IEnumerable<StadiumDisplayResponse>> GetAllStadiumsAsync();
        Task<StadiumDisplayResponse> GetStadiumByIdAsync(int id);
        Task CreateStadiumAsync(CreateNewStadiumRequest createNewStadiumRequest);
        Task<int> CreateAndReturnIdAsync(CreateNewStadiumRequest createNewStadiumRequest);
        Task<int> UpdateAndReturnIdAsync(UpdateStadiumRequest updateStadiumRequest);
        Task<IEnumerable<StadiumDisplayResponse>> GetStadiumsWithoutTeamAsync();
        Task UpdateTeamIdAsync(int stadiumId, int newTeamId);
        Task<bool> StadiumIsExistsAsync(int stadiumId);
        Task UpdateStadiumAsync(UpdateStadiumRequest updateStadiumRequest);
        Task<UpdateStadiumRequest> GetStadiumForUpdate(int id);
    }
}
