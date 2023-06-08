using FootballLeagueApp.DTOs.Requests.CoachRequests;
using FootballLeagueApp.DTOs.Responses.CoachResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.CoachService
{
    public interface ICoachService
    {
        Task<IEnumerable<CoachDisplayResponse>> GetAllCoaches();
        Task CreateCoachAsync(CreateNewCoachRequest createNewCoachRequest);
    }
}
