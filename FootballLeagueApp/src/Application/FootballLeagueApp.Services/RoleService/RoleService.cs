using AutoMapper;
using FootballLeagueApp.DTOs.Requests.RoleRequests;
using FootballLeagueApp.DTOs.Responses.RoleRequests;
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

        public async Task<IEnumerable<RoleDisplayResponse>> GetAllRoles()
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
    }
}
