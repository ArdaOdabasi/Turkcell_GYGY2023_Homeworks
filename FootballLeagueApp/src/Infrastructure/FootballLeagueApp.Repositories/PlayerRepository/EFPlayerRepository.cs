using FootballLeagueApp.Entities;
using FootballLeagueApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.PlayerRepository
{
    public class EFPlayerRepository : IPlayerRepository
    {
        private readonly FootballLeagueDbContext footballLeagueDbContext;

        public EFPlayerRepository(FootballLeagueDbContext footballLeagueDbContext)
        {
            this.footballLeagueDbContext = footballLeagueDbContext;
        }

        public void Create(Player entity)
        {
            footballLeagueDbContext.Players.Add(entity);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task CreateAsync(Player entity)
        {
            await footballLeagueDbContext.Players.AddAsync(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingPlayer = footballLeagueDbContext.Players.Find(id);
            footballLeagueDbContext.Players.Remove(deletingPlayer);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingPlayer = await footballLeagueDbContext.Players.FindAsync(id);
            footballLeagueDbContext.Players.Remove(deletingPlayer);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public Player? Get(int id)
        {
            return footballLeagueDbContext.Players.SingleOrDefault(x => x.Id == id);
        }

        public async Task<IList<Player?>> GetAllByNationalityAsync(string nationality)
        {
            return await footballLeagueDbContext.Players
                .AsNoTracking()
                .Where(p => p.Nationality == nationality)
                .ToListAsync();
        }

        public IList<Player?> GetAll()
        {
            return footballLeagueDbContext.Players.ToList();
        }

        public async Task<IList<Player?>> GetAllAsync()
        {
            return await footballLeagueDbContext.Players.ToListAsync();
        }

        public IList<Player> GetAllWithPredicate(Expression<Func<Player, bool>> predicate)
        {
            return footballLeagueDbContext.Players.Where(predicate).ToList();
        }

        public async Task<Player?> GetAsync(int id)
        {
            return await footballLeagueDbContext.Players.FirstOrDefaultAsync(c => c.Id == id);
        }

        public void Update(Player entity)
        {
            footballLeagueDbContext.Players.Update(entity);
            footballLeagueDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Player entity)
        {
            footballLeagueDbContext.Players.Update(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }
    }
}
