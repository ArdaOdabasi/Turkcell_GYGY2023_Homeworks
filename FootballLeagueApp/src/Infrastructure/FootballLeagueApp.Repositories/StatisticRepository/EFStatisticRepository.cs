using FootballLeagueApp.Entities;
using FootballLeagueApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.StatisticRepository
{
    public class EFStatisticRepository : IStatisticRepository
    {
        private readonly FootballLeagueDbContext footballLeagueDbContext;

        public EFStatisticRepository(FootballLeagueDbContext footballLeagueDbContext)
        {
            this.footballLeagueDbContext = footballLeagueDbContext;
        }

        public void Create(Statistic entity)
        {
            footballLeagueDbContext.Statistics.Add(entity);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task<int> CreateAndReturnIdAsync(Statistic entity)
        {
            await footballLeagueDbContext.Statistics.AddAsync(entity);
            await footballLeagueDbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task CreateAsync(Statistic entity)
        {
            await footballLeagueDbContext.Statistics.AddAsync(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingStatistic = footballLeagueDbContext.Statistics.Find(id);
            footballLeagueDbContext.Statistics.Remove(deletingStatistic);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingStatistic = await footballLeagueDbContext.Statistics.FindAsync(id);
            footballLeagueDbContext.Statistics.Remove(deletingStatistic);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public Statistic? Get(int id)
        {
            return footballLeagueDbContext.Statistics.SingleOrDefault(s => s.Id == id);
        }

        public IList<Statistic?> GetAll()
        {
            return footballLeagueDbContext.Statistics.ToList();
        }

        public async Task<IList<Statistic?>> GetAllAsync()
        {
            return await footballLeagueDbContext.Statistics.ToListAsync();
        }

        public IList<Statistic> GetAllWithPredicate(Expression<Func<Statistic, bool>> predicate)
        {
            return footballLeagueDbContext.Statistics.Where(predicate).ToList();
        }

        public async Task<Statistic?> GetAsync(int id)
        {
            return await footballLeagueDbContext.Statistics.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<Statistic?> GetStatisticByPlayerIdAsync(int playerId)
        {
            return await footballLeagueDbContext.Statistics.FirstOrDefaultAsync(s => s.PlayerId == playerId);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await footballLeagueDbContext.Statistics.AnyAsync(s => s.Id == id);
        }

        public void Update(Statistic entity)
        {
            footballLeagueDbContext.Statistics.Update(entity);
            footballLeagueDbContext.SaveChanges();
        }
   
        public async Task UpdateAsync(Statistic entity)
        {
            footballLeagueDbContext.Statistics.Update(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task<int> UpdateAndReturnIdAsync(Statistic entity)
        {
            footballLeagueDbContext.Statistics.Update(entity);
            await footballLeagueDbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdatePlayerIdAsync(int statisticId, int newPlayerId)
        {
            var statistics = await footballLeagueDbContext.Statistics.Where(s => s.PlayerId == newPlayerId || s.Id == statisticId).ToListAsync();

            foreach (var statistic in statistics)
            {
                statistic.PlayerId = statistic.Id == statisticId ? newPlayerId : null;
            }

            await footballLeagueDbContext.SaveChangesAsync();
        }

    }
}
