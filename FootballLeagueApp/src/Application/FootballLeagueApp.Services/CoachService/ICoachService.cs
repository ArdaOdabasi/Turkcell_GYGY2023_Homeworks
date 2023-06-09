using FootballLeagueApp.DTOs.Requests.CoachRequests;
using FootballLeagueApp.DTOs.Requests.MatchRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.CoachResponses;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.CoachService
{
    public interface ICoachService
    {
        Task<IEnumerable<CoachDisplayResponse>> GetAllCoachesAsync();
        Task CreateCoachAsync(CreateNewCoachRequest createNewCoachRequest);
        Task<IEnumerable<CoachDisplayResponse>> GetCoachesWithoutTeamAsync();
        Task<int> CreateAndReturnIdAsync(CreateNewCoachRequest createNewCoachRequest);
        Task<int> UpdateAndReturnIdAsync(UpdateCoachRequest updateCoachRequest);
        Task UpdateTeamIdAsync(int coachId, int newTeamId);
        Task<bool> CoachIsExistsAsync(int coachId);
        Task UpdateCoachAsync(UpdateCoachRequest updateCoachRequest);
        Task<UpdateCoachRequest> GetCoachForUpdate(int id);
    }
}
