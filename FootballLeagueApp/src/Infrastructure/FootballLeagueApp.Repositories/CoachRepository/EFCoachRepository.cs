using FootballLeagueApp.Entities;
using FootballLeagueApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.CoachRepository
{
    public class EFCoachRepository : ICoachRepository
    {
        private readonly FootballLeagueDbContext footballLeagueDbContext;

        public EFCoachRepository(FootballLeagueDbContext footballLeagueDbContext)
        {
            this.footballLeagueDbContext = footballLeagueDbContext;
        }

        public void Create(Coach entity)
        {
            footballLeagueDbContext.Coaches.Add(entity);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task CreateAsync(Coach entity)
        {
            await footballLeagueDbContext.Coaches.AddAsync(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingCoach = footballLeagueDbContext.Coaches.Find(id);
            footballLeagueDbContext.Coaches.Remove(deletingCoach);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingCoach = await footballLeagueDbContext.Coaches.FindAsync(id);
            footballLeagueDbContext.Coaches.Remove(deletingCoach);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public Coach? Get(int id)
        {
            return footballLeagueDbContext.Coaches.SingleOrDefault(x => x.Id == id);
        }

        public IList<Coach?> GetAll()
        {
            return footballLeagueDbContext.Coaches.ToList();
        }

        public async Task<IList<Coach?>> GetAllAsync()
        {
            return await footballLeagueDbContext.Coaches.ToListAsync();
        }

        public IList<Coach> GetAllWithPredicate(Expression<Func<Coach, bool>> predicate)
        {
            return footballLeagueDbContext.Coaches.Where(predicate).ToList();
        }

        public async Task<Coach?> GetAsync(int id)
        {
            return await footballLeagueDbContext.Coaches.FirstOrDefaultAsync(c => c.Id == id);
        }

        public void Update(Coach entity)
        {
            footballLeagueDbContext.Coaches.Update(entity);
            footballLeagueDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Coach entity)
        {
            footballLeagueDbContext.Coaches.Update(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }
    }
}
