using AutoMapper;
using FootballLeagueApp.DTOs.Requests.StandingRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.StandingResponses;
using FootballLeagueApp.Entities;
using FootballLeagueApp.Repositories.StandingRepository;
using FootballLeagueApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.StandingService
{
    public class StandingService : IStandingService
    {
        private readonly IStandingRepository _repository;
        private readonly IMapper _mapper;

        public StandingService(IStandingRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StandingDisplayResponse>> GetAllStandingsAsync()
        {
            var standings = await _repository.GetAllAsync();
            var responses = standings.ConvertStandingsToDisplayResponses(_mapper);
            return responses;
        }

        public async Task CreateStandingAsync(CreateNewStandingRequest createNewStandingRequest)
        {
            var standing = _mapper.ConvertRequestToStanding(createNewStandingRequest);
            await _repository.CreateAsync(standing);
        }

        public async Task<IEnumerable<StandingDisplayResponse>> GetAllStandingsOrderedByScoreAsync()
        {
            var standings = await _repository.GetAllStandingsOrderedByScoreAsync();
            var responses = standings.ConvertStandingsToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<bool> StandingIsExistsAsync(int standingId)
        {
            return await _repository.IsExistsAsync(standingId);
        }

        public async Task UpdateStandingAsync(UpdateStandingRequest updateStandingRequest)
        {
            var team = _mapper.ConvertUpdateRequestToStanding(updateStandingRequest);
            await _repository.UpdateAsync(team);
        }

        public async Task<UpdateStandingRequest> GetStandingForUpdate(int id)
        {
            var standing = await _repository.GetAsync(id);
            return _mapper.ConvertStandingToUpdateRequest(standing);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
