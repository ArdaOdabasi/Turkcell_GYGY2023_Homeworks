using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.CoachRepository
{
    public interface ICoachRepository : IRepository<Coach>
    {
        Task<IEnumerable<Coach?>> GetCoachesWithoutTeamAsync();
        Task UpdateTeamIdAsync(int coachId, int newTeamId);
        Task<int> CreateAndReturnIdAsync(Coach entity);
        Task<int> UpdateAndReturnIdAsync(Coach entity);
    }
}
