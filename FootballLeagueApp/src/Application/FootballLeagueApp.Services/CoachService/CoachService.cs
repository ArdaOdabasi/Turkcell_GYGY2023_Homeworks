using AutoMapper;
using FootballLeagueApp.DTOs.Responses.CoachResponses;
using FootballLeagueApp.Repositories.CoachRepository;
using FootballLeagueApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.CoachService
{
    public class CoachService : ICoachService
    {
        private readonly ICoachRepository _repository;
        private readonly IMapper _mapper;

        public CoachService(ICoachRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<CoachDisplayResponse>> GetAllCoaches()
        {
            var coaches = await _repository.GetAllAsync();
            var responses = coaches.ConvertCoachesToDisplayResponses(_mapper);
            return responses;
        }
    }
}
