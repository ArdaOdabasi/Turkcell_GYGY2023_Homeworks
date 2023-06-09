using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.StatisticRepository
{
    public interface IStatisticRepository : IRepository<Statistic>
    {
        Task<int> CreateAndReturnIdAsync(Statistic entity);
        Task<int> UpdateAndReturnIdAsync(Statistic entity);
        Task UpdatePlayerIdAsync(int statisticId, int newPlayerId);
        Task<Statistic?> GetStatisticByPlayerIdAsync(int playerId);
    }
}
