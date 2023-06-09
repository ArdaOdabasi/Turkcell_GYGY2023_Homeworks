using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.TeamRepository
{
    public interface ITeamRepository : IRepository<Team>
    {
        Task<List<Team>> GetTeamsWithoutCoachAsync();
        Task UpdateStadiumIdAsync(int teamId, int newStadiumId);
        Task<IEnumerable<Team?>> GetTeamsWithoutStadiumAsync();
        Task<int> CreateAndReturnIdAsync(Team entity);
        Task<int> UpdateAndReturnIdAsync(Team entity);
        Task UpdateCoachIdAsync(int teamId, int newCoachId);
        Task AddPlayerToTeam(Player player);
    }
}
