using FootballLeagueApp.DTOs.Responses.StatisticResponses;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.StatisticService
{
    public interface IStatisticService
    {
        Task<IEnumerable<StatisticDisplayResponse>> GetAllStatistics();
        Task<StatisticDisplayResponse> GetStatisticById(int id);
    }
}
