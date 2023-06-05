using AutoMapper;
using FootballLeagueApp.DTOs.Responses.StatisticResponses;
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

        public async Task<IEnumerable<StatisticDisplayResponse>> GetAllStatistics()
        {
            var statistics = await _repository.GetAllAsync();
            var responses = statistics.ConvertStatisticsToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<StatisticDisplayResponse> GetStatisticById(int id)
        {
            var statistic = await _repository.GetAsync(id);
            var response = statistic.ConvertStatisticToDisplayResponses(_mapper);
            return response;
        }
    }
}
