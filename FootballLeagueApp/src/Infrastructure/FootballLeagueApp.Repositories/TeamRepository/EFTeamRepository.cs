using FootballLeagueApp.Entities;
using FootballLeagueApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.TeamRepository
{
    public class EFTeamRepository : ITeamRepository
    {
        private readonly FootballLeagueDbContext footballLeagueDbContext;

        public EFTeamRepository(FootballLeagueDbContext footballLeagueDbContext)
        {
            this.footballLeagueDbContext = footballLeagueDbContext;
        }

        public void Create(Team entity)
        {
            footballLeagueDbContext.Teams.Add(entity);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task CreateAsync(Team entity)
        {
            await footballLeagueDbContext.Teams.AddAsync(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingTeam = footballLeagueDbContext.Teams.Find(id);
            footballLeagueDbContext.Teams.Remove(deletingTeam);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingTeam = await footballLeagueDbContext.Teams.FindAsync(id);
            footballLeagueDbContext.Teams.Remove(deletingTeam);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public Team? Get(int id)
        {
            return footballLeagueDbContext.Teams.SingleOrDefault(x => x.Id == id);
        }

        public IList<Team?> GetAll()
        {
            return footballLeagueDbContext.Teams.ToList();
        }

        public async Task<IList<Team?>> GetAllAsync()
        {
            return await footballLeagueDbContext.Teams.ToListAsync();
        }

        public IList<Team> GetAllWithPredicate(Expression<Func<Team, bool>> predicate)
        {
            return footballLeagueDbContext.Teams.Where(predicate).ToList();
        }

        public async Task<Team?> GetAsync(int id)
        {
            return await footballLeagueDbContext.Teams.FirstOrDefaultAsync(c => c.Id == id);
        }

        public void Update(Team entity)
        {
            footballLeagueDbContext.Teams.Update(entity);
            footballLeagueDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Team entity)
        {
            footballLeagueDbContext.Teams.Update(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }
    }
}
