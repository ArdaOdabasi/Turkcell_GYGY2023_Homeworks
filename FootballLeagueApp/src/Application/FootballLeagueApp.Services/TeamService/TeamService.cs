using AutoMapper;
using FootballLeagueApp.DTOs.Requests.PlayerRequests;
using FootballLeagueApp.DTOs.Requests.StadiumRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Requests.UserRequests;
using FootballLeagueApp.DTOs.Responses.PlayerResponses;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.Entities;
using FootballLeagueApp.Repositories.TeamRepository;
using FootballLeagueApp.Services.Extensions;
using Microsoft.EntityFrameworkCore;
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

        public async Task<IEnumerable<TeamDisplayResponse>> GetAllTeamsAsync()
        {
            var teams = await _repository.GetAllAsync();
            var responses = teams.ConvertTeamsToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<TeamDisplayResponse> GetTeamByIdAsync(int id)
        {
            var team = await _repository.GetAsync(id);
            var response = team.ConvertTeamToDisplayResponse(_mapper);
            return response;
        }

        public async Task CreateTeamAsync(CreateNewTeamRequest createNewTeamRequest)
        {
            var team = _mapper.ConvertRequestToTeam(createNewTeamRequest);
            await _repository.CreateAsync(team);
        }

        public async Task<IEnumerable<TeamDisplayResponse>> GetTeamsWithoutCoachAsync()
        {
            var teams = await _repository.GetTeamsWithoutCoachAsync();
            var responses = teams.ConvertTeamsToDisplayResponses(_mapper);
            return responses;
        }

        public async Task UpdateStadiumIdAsync(int teamId, int newStadiumId)
        {
            await _repository.UpdateStadiumIdAsync(teamId, newStadiumId);
        }

        public async Task<IEnumerable<TeamDisplayResponse?>> GetTeamsWithoutStadiumAsync()
        {
            var teams = await _repository.GetTeamsWithoutStadiumAsync();
            var responses = teams.ConvertTeamsToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewTeamRequest createNewTeamRequest)
        {
            var team = _mapper.ConvertRequestToTeam(createNewTeamRequest);
            await _repository.CreateAsync(team);

            return team.Id;
        }

        public async Task UpdateCoachIdAsync(int teamId, int newCoachId)
        {
            await _repository.UpdateCoachIdAsync(teamId, newCoachId);
        }

        public async Task AddPlayerToTeam(CreateNewPlayerRequest createNewPlayerRequest)
        {
            var player = _mapper.ConvertRequestToPlayer(createNewPlayerRequest);
            await _repository.AddPlayerToTeam(player);
        }

        public async Task<bool> TeamIsExistsAsync(int teamId)
        {
            return await _repository.IsExistsAsync(teamId);
        }

        public async Task UpdateTeamAsync(UpdateTeamRequest updateTeamRequest)
        {
            var team = _mapper.ConvertUpdateRequestToTeam(updateTeamRequest);
            await _repository.UpdateAsync(team);
        }

        public async Task<int> UpdateAndReturnIdAsync(UpdateTeamRequest updateTeamRequest)
        {
            var team = _mapper.ConvertUpdateRequestToTeam(updateTeamRequest);
            await _repository.UpdateAsync(team);

            return team.Id;
        }

        public async Task<UpdateTeamRequest> GetTeamForUpdate(int id)
        {
            var team = await _repository.GetAsync(id);
            return _mapper.ConvertTeamToUpdateRequest(team);
        }     
    }
}
