using FootballLeagueApp.Entities;
using FootballLeagueApp.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.RoleRepository
{
    public class EFRoleRepository : IRoleRepository
    {
        private readonly FootballLeagueDbContext footballLeagueDbContext;

        public EFRoleRepository(FootballLeagueDbContext footballLeagueDbContext)
        {
            this.footballLeagueDbContext = footballLeagueDbContext;
        }

        public void Create(Role entity)
        {
            footballLeagueDbContext.Roles.Add(entity);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task CreateAsync(Role entity)
        {
            await footballLeagueDbContext.Roles.AddAsync(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            var deletingRole = footballLeagueDbContext.Roles.Find(id);
            footballLeagueDbContext.Roles.Remove(deletingRole);
            footballLeagueDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var deletingRole = await footballLeagueDbContext.Roles.FindAsync(id);
            footballLeagueDbContext.Roles.Remove(deletingRole);
            await footballLeagueDbContext.SaveChangesAsync();
        }

        public Role? Get(int id)
        {
            return footballLeagueDbContext.Roles.SingleOrDefault(x => x.Id == id);
        }

        public IList<Role?> GetAll()
        {
            return footballLeagueDbContext.Roles.ToList();
        }

        public async Task<IList<Role?>> GetAllAsync()
        {
            return await footballLeagueDbContext.Roles.ToListAsync();
        }

        public IList<Role> GetAllWithPredicate(Expression<Func<Role, bool>> predicate)
        {
            return footballLeagueDbContext.Roles.Where(predicate).ToList();
        }

        public async Task<Role?> GetAsync(int id)
        {
            return await footballLeagueDbContext.Roles.FirstOrDefaultAsync(c => c.Id == id);
        }

        public void Update(Role entity)
        {
            footballLeagueDbContext.Roles.Update(entity);
            footballLeagueDbContext.SaveChanges();
        }

        public async Task UpdateAsync(Role entity)
        {
            footballLeagueDbContext.Roles.Update(entity);
            await footballLeagueDbContext.SaveChangesAsync();
        }
    }
}
