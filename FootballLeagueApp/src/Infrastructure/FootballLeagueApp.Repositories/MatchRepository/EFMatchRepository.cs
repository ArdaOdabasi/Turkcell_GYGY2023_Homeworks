using FootballLeagueApp.Entities;
using FootballLeagueApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.MatchRepository
{
    public class EFMatchRepository : IMatchRepository
    {
        private readonly FootballLeagueDbContext footballLeagueDbContext;

        public EFMatchRepository(FootballLeagueDbContext footballLeagueDbContext)
        {
            this.footballLeagueDbContext = footballLeagueDbContext;
        }

        public void Create(Match entity)
        {
            footballLeagueDbContext.Matches.Add(entity);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task CreateAsync(Match entity)
        {
            await footballLeagueDbContext.Matches.AddAsync(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingMatch = footballLeagueDbContext.Matches.Find(id);
            footballLeagueDbContext.Matches.Remove(deletingMatch);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingMatch = await footballLeagueDbContext.Matches.FindAsync(id);
            footballLeagueDbContext.Matches.Remove(deletingMatch);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public Match? Get(int id)
        {
            return footballLeagueDbContext.Matches.SingleOrDefault(m => m.Id == id);
        }

        public IList<Match?> GetAll()
        {
            return footballLeagueDbContext.Matches.ToList();
        }

        public async Task<IList<Match?>> GetAllAsync()
        {
            return await footballLeagueDbContext.Matches.ToListAsync();
        }

        public IList<Match> GetAllWithPredicate(Expression<Func<Match, bool>> predicate)
        {
            return footballLeagueDbContext.Matches.Where(predicate).ToList();
        }

        public async Task<Match?> GetAsync(int id)
        {
            return await footballLeagueDbContext.Matches.FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await footballLeagueDbContext.Matches.AnyAsync(m => m.Id == id);
        }

        public void Update(Match entity)
        {
            footballLeagueDbContext.Matches.Update(entity);
            footballLeagueDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Match entity)
        {
            footballLeagueDbContext.Matches.Update(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }
    }
}
