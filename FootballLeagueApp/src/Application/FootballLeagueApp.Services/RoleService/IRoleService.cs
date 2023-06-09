using FootballLeagueApp.DTOs.Requests.RoleRequests;
using FootballLeagueApp.DTOs.Requests.StadiumRequests;
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
        Task<IEnumerable<RoleDisplayResponse>> GetAllRolesAsync();
        Task CreateRoleAsync(CreateNewRoleRequest createNewRoleRequest);
        Task<bool> RoleIsExistsAsync(int roleId);
        Task UpdateRoleAsync(UpdateRoleRequest updateRoleRequest);
        Task<UpdateRoleRequest> GetRoleForUpdate(int id);
    }
}
