using FootballLeagueApp.Entities;
using FootballLeagueApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.StadiumRepository
{
    public class EFStadiumRepository : IStadiumRepository
    {
        private readonly FootballLeagueDbContext footballLeagueDbContext;

        public EFStadiumRepository(FootballLeagueDbContext footballLeagueDbContext)
        {
            this.footballLeagueDbContext = footballLeagueDbContext;
        }

        public void Create(Stadium entity)
        {
            footballLeagueDbContext.Stadiums.Add(entity);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task CreateAsync(Stadium entity)
        {
            await footballLeagueDbContext.Stadiums.AddAsync(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingStadium = footballLeagueDbContext.Stadiums.Find(id);
            footballLeagueDbContext.Stadiums.Remove(deletingStadium);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingStadium = await footballLeagueDbContext.Stadiums.FindAsync(id);
            footballLeagueDbContext.Stadiums.Remove(deletingStadium);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public Stadium? Get(int id)
        {
            return footballLeagueDbContext.Stadiums.SingleOrDefault(x => x.Id == id);
        }

        public IList<Stadium?> GetAll()
        {
            return footballLeagueDbContext.Stadiums.ToList();
        }

        public async Task<IList<Stadium?>> GetAllAsync()
        {
            return await footballLeagueDbContext.Stadiums.ToListAsync();
        }

        public IList<Stadium> GetAllWithPredicate(Expression<Func<Stadium, bool>> predicate)
        {
            return footballLeagueDbContext.Stadiums.Where(predicate).ToList();
        }

        public async Task<Stadium?> GetAsync(int id)
        {
            return await footballLeagueDbContext.Stadiums.FirstOrDefaultAsync(c => c.Id == id);
        }

        public void Update(Stadium entity)
        {
            footballLeagueDbContext.Stadiums.Update(entity);
            footballLeagueDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Stadium entity)
        {
            footballLeagueDbContext.Stadiums.Update(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }
    }
}
