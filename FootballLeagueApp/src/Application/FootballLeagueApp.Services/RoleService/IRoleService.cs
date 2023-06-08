using FootballLeagueApp.DTOs.Requests.RoleRequests;
using FootballLeagueApp.DTOs.Responses.RoleRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.RoleService
{
    public interface IRoleService
    {
        Task<IEnumerable<RoleDisplayResponse>> GetAllRoles();
        Task CreateRoleAsync(CreateNewRoleRequest createNewRoleRequest);
    }
}
