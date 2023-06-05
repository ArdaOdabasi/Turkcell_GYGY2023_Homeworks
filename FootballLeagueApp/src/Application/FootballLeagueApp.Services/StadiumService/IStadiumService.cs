using FootballLeagueApp.DTOs.Responses.StadiumResponses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.StadiumService
{
    public interface IStadiumService
    {
        Task<IEnumerable<StadiumDisplayResponse>> GetAllStadiums();
        Task<StadiumDisplayResponse> GetStadiumById(int id);
    }
}
