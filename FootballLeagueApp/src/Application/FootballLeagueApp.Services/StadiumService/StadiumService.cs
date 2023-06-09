using AutoMapper;
using FootballLeagueApp.DTOs.Requests.StadiumRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.StadiumResponses;
using FootballLeagueApp.Entities;
using FootballLeagueApp.Repositories.StadiumRepository;
using FootballLeagueApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.StadiumService
{
    public class StadiumService : IStadiumService
    {
        private readonly IStadiumRepository _repository;
        private readonly IMapper _mapper;

        public StadiumService(IStadiumRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StadiumDisplayResponse>> GetAllStadiumsAsync()
        {
            var stadiums = await _repository.GetAllAsync();
            var responses = stadiums.ConvertStadiumsToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<StadiumDisplayResponse> GetStadiumByIdAsync(int id)
        {
            var stadium = await _repository.GetAsync(id);
            var response = stadium.ConvertStadiumToDisplayResponses(_mapper);
            return response;
        }

        public async Task CreateStadiumAsync(CreateNewStadiumRequest createNewStadiumRequest)
        {
            var stadium = _mapper.ConvertRequestToStadium(createNewStadiumRequest);
            await _repository.CreateAsync(stadium);
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewStadiumRequest createNewStadiumRequest)
        {
            var stadium = _mapper.ConvertRequestToStadium(createNewStadiumRequest);
            await _repository.CreateAsync(stadium);

            return stadium.Id;
        }

        public async Task<IEnumerable<StadiumDisplayResponse>> GetStadiumsWithoutTeamAsync()
        {
            var stadiums = await _repository.GetStadiumsWithoutTeamAsync();
            var responses = stadiums.ConvertStadiumsToDisplayResponses(_mapper);
            return responses;
        }

        public async Task UpdateTeamIdAsync(int stadiumId, int newTeamId)
        {
            await _repository.UpdateTeamIdAsync(stadiumId, newTeamId);
        }

        public async Task<bool> StadiumIsExistsAsync(int stadiumId)
        {
            return await _repository.IsExistsAsync(stadiumId);
        }

        public async Task UpdateStadiumAsync(UpdateStadiumRequest updateStadiumRequest)
        {
            var team = _mapper.ConvertUpdateRequestToStadium(updateStadiumRequest);
            await _repository.UpdateAsync(team);
        }

        public async Task<int> UpdateAndReturnIdAsync(UpdateStadiumRequest updateStadiumRequest)
        {
            var team = _mapper.ConvertUpdateRequestToStadium(updateStadiumRequest);
            await _repository.UpdateAsync(team);

            return team.Id;
        }

        public async Task<UpdateStadiumRequest> GetStadiumForUpdate(int id)
        {
            var stadium = await _repository.GetAsync(id);
            return _mapper.ConvertStadiumToUpdateRequest(stadium);
        }     
    }
}
