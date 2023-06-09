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
            return footballLeagueDbContext.Teams.SingleOrDefault(t => t.Id == id);
        }

        public IList<Team?> GetAll()
        {
            return footballLeagueDbContext.Teams.ToList();
        }

        public async Task<IList<Team?>> GetAllAsync()
        {
            return await footballLeagueDbContext.Teams.ToListAsync();
        }

        public async Task<IEnumerable<Team?>> GetTeamsWithoutStadiumAsync()
        {
            return await footballLeagueDbContext.Teams.Where(t => t.StadiumId == null).ToListAsync();
        }

        public IList<Team> GetAllWithPredicate(Expression<Func<Team, bool>> predicate)
        {
            return footballLeagueDbContext.Teams.Where(predicate).ToList();
        }

        public async Task<Team?> GetAsync(int id)
        {
            return await footballLeagueDbContext.Teams.FirstOrDefaultAsync(t => t.Id == id);
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

        public async Task<int> UpdateAndReturnIdAsync(Team entity)
        {
            footballLeagueDbContext.Teams.Update(entity);
            await footballLeagueDbContext.SaveChangesAsync();

            return entity.Id;
        }

        public async Task UpdateStadiumIdAsync(int teamId, int newStadiumId)
        {
            var teams = await footballLeagueDbContext.Teams
                .Where(t => t.StadiumId == newStadiumId || t.Id == teamId)
                .ToListAsync();

            foreach (var team in teams)
            {
                team.StadiumId = team.Id == teamId ? newStadiumId : null;
            }

            await footballLeagueDbContext.SaveChangesAsync();
        }


        public async Task<List<Team>> GetTeamsWithoutCoachAsync()
        {
            return await footballLeagueDbContext.Teams.Where(t => t.CoachId == null).ToListAsync();
        }

        public async Task<int> CreateAndReturnIdAsync(Team entity)
        {
            await footballLeagueDbContext.Teams.AddAsync(entity);
            await footballLeagueDbContext.SaveChangesAsync();

            return entity.Id;
        }
    
        public async Task UpdateCoachIdAsync(int teamId, int newCoachId)
        {
            var coaches = await footballLeagueDbContext.Coaches
                .Where(c => c.TeamId == newCoachId || c.TeamId == teamId)
                .ToListAsync();

            foreach (var coach in coaches)
            {
                coach.TeamId = coach.TeamId == teamId ? newCoachId : null;
            }

            await footballLeagueDbContext.SaveChangesAsync();
        }


        public async Task AddPlayerToTeam(Player player)
        {
            var team = await footballLeagueDbContext.Teams.FindAsync(player.TeamId);

            if (team != null)
            {
                team.Players.Add(player);
                await footballLeagueDbContext.SaveChangesAsync();
            }
        }

        public async Task<bool> IsExistsAsync(int id)
        {
            return await footballLeagueDbContext.Teams.AnyAsync(t => t.Id == id);
        }      
    }
}
