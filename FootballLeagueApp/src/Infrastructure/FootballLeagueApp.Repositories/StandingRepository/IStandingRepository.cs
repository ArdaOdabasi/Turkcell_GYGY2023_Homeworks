using FootballLeagueApp.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.StandingRepository
{
    public interface IStandingRepository : IRepository<Standing>
    {
        Task<IEnumerable<Standing>> GetAllStandingsOrderedByScore();
    }
}
