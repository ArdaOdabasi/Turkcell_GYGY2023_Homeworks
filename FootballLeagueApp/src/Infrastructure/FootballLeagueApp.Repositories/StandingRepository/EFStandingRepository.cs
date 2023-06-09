using FootballLeagueApp.Entities;
using FootballLeagueApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.StandingRepository
{
    public class EFStandingRepository : IStandingRepository
    {
        private readonly FootballLeagueDbContext footballLeagueDbContext;

        public EFStandingRepository(FootballLeagueDbContext footballLeagueDbContext)
        {
            this.footballLeagueDbContext = footballLeagueDbContext;
        }

        public void Create(Standing entity)
        {
            footballLeagueDbContext.Standings.Add(entity);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task CreateAsync(Standing entity)
        {
            await footballLeagueDbContext.Standings.AddAsync(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingStanding = footballLeagueDbContext.Standings.Find(id);
            footballLeagueDbContext.Standings.Remove(deletingStanding);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingStanding = await footballLeagueDbContext.Standings.FindAsync(id);
            footballLeagueDbContext.Standings.Remove(deletingStanding);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public Standing? Get(int id)
        {
            return footballLeagueDbContext.Standings.SingleOrDefault(s => s.Id == id);
        }

        public IList<Standing?> GetAll()
        {
            return footballLeagueDbContext.Standings.ToList();
        }

        public async Task<IList<Standing?>> GetAllAsync()
        {
            return await footballLeagueDbContext.Standings.ToListAsync();
        }

        public async Task<IEnumerable<Standing>> GetAllStandingsOrderedByScoreAsync()
        {
            var standings = await footballLeagueDbContext.Standings.OrderByDescending(s => s.Score).ToListAsync();
            return standings;
        }

        public IList<Standing> GetAllWithPredicate(Expression<Func<Standing, bool>> predicate)
        {
            return footballLeagueDbContext.Standings.Where(predicate).ToList();
        }

        public async Task<Standing?> GetAsync(int id)
        {
            return await footballLeagueDbContext.Standings.FirstOrDefaultAsync(s => s.Id == id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await footballLeagueDbContext.Standings.AnyAsync(s => s.Id == id);
        }

        public void Update(Standing entity)
        {
            footballLeagueDbContext.Standings.Update(entity);
            footballLeagueDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Standing entity)
        {
            footballLeagueDbContext.Standings.Update(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }
    }
}
