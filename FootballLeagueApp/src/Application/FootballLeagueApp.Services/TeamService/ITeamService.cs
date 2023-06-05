using FootballLeagueApp.DTOs.Responses.TeamResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.TeamService
{
    public interface ITeamService
    {
        Task<IEnumerable<TeamDisplayResponse>> GetAllTeams();
        Task<TeamDisplayResponse> GetTeamById(int id);
    }
}
