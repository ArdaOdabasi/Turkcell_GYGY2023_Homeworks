using AutoMapper;
using FootballLeagueApp.DTOs.Requests.RoleRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.RoleRequests;
using FootballLeagueApp.Entities;
using FootballLeagueApp.Repositories.RoleRepository;
using FootballLeagueApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.RoleService
{
    public class RoleService : IRoleService
    {
        private readonly IRoleRepository _repository;
        private readonly IMapper _mapper;

        public RoleService(IRoleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<RoleDisplayResponse>> GetAllRolesAsync()
        {
            var roles = await _repository.GetAllAsync();
            var responses = roles.ConvertRolesToDisplayResponses(_mapper);
            return responses;
        }

        public async Task CreateRoleAsync(CreateNewRoleRequest createNewRoleRequest)
        {
            var role = _mapper.ConvertRequestToRole(createNewRoleRequest);
            await _repository.CreateAsync(role);
        }

        public async Task<bool> RoleIsExistsAsync(int roleId)
        {
            return await _repository.IsExistsAsync(roleId);
        }

        public async Task UpdateRoleAsync(UpdateRoleRequest updateRoleRequest)
        {
            var team = _mapper.ConvertUpdateRequestToRole(updateRoleRequest);
            await _repository.UpdateAsync(team);
        }

        public async Task<UpdateRoleRequest> GetRoleForUpdate(int id)
        {
            var role = await _repository.GetAsync(id);
            return _mapper.ConvertRoleToUpdateRequest(role);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
