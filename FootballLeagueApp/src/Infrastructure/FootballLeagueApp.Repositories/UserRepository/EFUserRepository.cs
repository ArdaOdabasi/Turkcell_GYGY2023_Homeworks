using FootballLeagueApp.Entities;
using FootballLeagueApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.UserRepository
{
    public class EFUserRepository : IUserRepository
    {
        private readonly FootballLeagueDbContext footballLeagueDbContext;

        public EFUserRepository(FootballLeagueDbContext footballLeagueDbContext)
        {
            this.footballLeagueDbContext = footballLeagueDbContext;
        }

        public void Create(User entity)
        {
            footballLeagueDbContext.Users.Add(entity);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task CreateAsync(User entity)
        {
            await footballLeagueDbContext.Users.AddAsync(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingUser = footballLeagueDbContext.Users.Find(id);
            footballLeagueDbContext.Users.Remove(deletingUser);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingUser = await footballLeagueDbContext.Users.FindAsync(id);
            footballLeagueDbContext.Users.Remove(deletingUser);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public User? Get(int id)
        {
            return footballLeagueDbContext.Users.SingleOrDefault(x => x.Id == id);
        }

        public IList<User?> GetAll()
        {
            return footballLeagueDbContext.Users.ToList();
        }

        public async Task<IList<User?>> GetAllAsync()
        {
            return await footballLeagueDbContext.Users.ToListAsync();
        }

        public IList<User> GetAllWithPredicate(Expression<Func<User, bool>> predicate)
        {
            return footballLeagueDbContext.Users.Where(predicate).ToList();
        }

        public async Task<User?> GetAsync(int id)
        {
            return await footballLeagueDbContext.Users.FirstOrDefaultAsync(c => c.Id == id);
        }

        public void Update(User entity)
        {
            footballLeagueDbContext.Users.Update(entity);
            footballLeagueDbContext.SaveChanges();
        }

        public async Task UpdateAsync(User entity)
        {
            footballLeagueDbContext.Users.Update(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }
    }
}
