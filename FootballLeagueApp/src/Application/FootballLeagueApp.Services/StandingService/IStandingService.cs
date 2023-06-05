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
        Task<IEnumerable<StandingDisplayResponse>> GetAllStandings();
    }
}
