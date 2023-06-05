using AutoMapper;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.Repositories.TeamRepository;
using FootballLeagueApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.TeamService
{
    public class TeamService : ITeamService
    {
        private readonly ITeamRepository _repository;
        private readonly IMapper _mapper;

        public TeamService(ITeamRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TeamDisplayResponse>> GetAllTeams()
        {
            var teams = await _repository.GetAllAsync();
            var responses = teams.ConvertTeamsToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<TeamDisplayResponse> GetTeamById(int id)
        {
            var team = await _repository.GetAsync(id);
            var response = team.ConvertTeamToDisplayResponses(_mapper);
            return response;
        }
    }
}
