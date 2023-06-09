using AutoMapper;
using FootballLeagueApp.DTOs.Requests.StatisticRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.StatisticResponses;
using FootballLeagueApp.Entities;
using FootballLeagueApp.Repositories.StatisticRepository;
using FootballLeagueApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.StatisticService
{
    public class StatisticService : IStatisticService
    {
        private readonly IStatisticRepository _repository;
        private readonly IMapper _mapper;

        public StatisticService(IStatisticRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<StatisticDisplayResponse>> GetAllStatisticsAsync()
        {
            var statistics = await _repository.GetAllAsync();
            var responses = statistics.ConvertStatisticsToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<StatisticDisplayResponse> GetStatisticByIdAsync(int id)
        {
            var statistic = await _repository.GetAsync(id);
            var response = statistic.ConvertStatisticToDisplayResponses(_mapper);
            return response;
        }

        public async Task CreateStatisticAsync(CreateNewStatisticRequest createNewStatisticRequest)
        {
            var statistic = _mapper.ConvertRequestToStatistic(createNewStatisticRequest);
            await _repository.CreateAsync(statistic);
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewStatisticRequest createNewStatisticRequest)
        {
            var statistic = _mapper.ConvertRequestToStatistic(createNewStatisticRequest);
            await _repository.CreateAsync(statistic);

            return statistic.Id;
        }

        public async Task UpdatePlayerIdAsync(int statisticId, int newPlayerId)
        {
            await _repository.UpdatePlayerIdAsync(statisticId, newPlayerId);
        }

        public async Task<StatisticDisplayResponse?> GetStatisticByPlayerIdAsync(int playerId)
        {         
            var statistic = await _repository.GetStatisticByPlayerIdAsync(playerId);
            var response = statistic.ConvertStatisticToDisplayResponses(_mapper);
            return response;
        }

        public async Task<bool> StatisticIsExistsAsync(int statisticId)
        {
            return await _repository.IsExistsAsync(statisticId);
        }

        public async Task UpdateStatisticAsync(UpdateStatisticRequest updateStatisticRequest)
        {
            var team = _mapper.ConvertUpdateRequestToStatistic(updateStatisticRequest);
            await _repository.UpdateAsync(team);
        }

        public async Task<int> UpdateAndReturnIdAsync(UpdateStatisticRequest updateStatisticRequest)
        {
            var team = _mapper.ConvertUpdateRequestToStatistic(updateStatisticRequest);
            await _repository.UpdateAsync(team);

            return team.Id;
        }

        public async Task<UpdateStatisticRequest> GetStatisticForUpdate(int id)
        {
            var statistic = await _repository.GetAsync(id);
            return _mapper.ConvertStatisticToUpdateRequest(statistic);
        }     
    }
}
