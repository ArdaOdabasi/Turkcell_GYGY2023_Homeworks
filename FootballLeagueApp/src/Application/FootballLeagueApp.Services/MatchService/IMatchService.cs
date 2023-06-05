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
        Task<IEnumerable<MatchDisplayResponse>> GetAllMatches();
    }
}
