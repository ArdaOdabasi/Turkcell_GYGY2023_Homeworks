using AutoMapper;
using FootballLeagueApp.DTOs.Requests.StadiumRequests;
using FootballLeagueApp.DTOs.Responses.StadiumResponses;
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

        public async Task<IEnumerable<StadiumDisplayResponse>> GetAllStadiums()
        {
            var stadiums = await _repository.GetAllAsync();
            var responses = stadiums.ConvertStadiumsToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<StadiumDisplayResponse> GetStadiumById(int id)
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
    }
}
