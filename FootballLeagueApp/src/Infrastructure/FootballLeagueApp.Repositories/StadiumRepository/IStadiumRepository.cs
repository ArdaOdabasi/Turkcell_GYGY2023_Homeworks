using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.StadiumRepository
{
    public interface IStadiumRepository : IRepository<Stadium>
    {
        Task<int> CreateAndReturnIdAsync(Stadium entity);
        Task<int> UpdateAndReturnIdAsync(Stadium entity);
        Task<IEnumerable<Stadium?>> GetStadiumsWithoutTeamAsync();
        Task UpdateTeamIdAsync(int stadiumId, int newTeamId);
    }
}
