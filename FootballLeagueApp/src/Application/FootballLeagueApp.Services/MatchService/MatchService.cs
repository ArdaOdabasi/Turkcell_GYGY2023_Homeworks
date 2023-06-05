using AutoMapper;
using FootballLeagueApp.DTOs.Responses.MatchResponses;
using FootballLeagueApp.Repositories.MatchRepository;
using FootballLeagueApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.MatchService
{
    public class MatchService : IMatchService
    {
        private readonly IMatchRepository _repository;
        private readonly IMapper _mapper;

        public MatchService(IMatchRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<MatchDisplayResponse>> GetAllMatches()
        {
            var matches = await _repository.GetAllAsync();
            var responses = matches.ConvertMatchesToDisplayResponses(_mapper);
            return responses;
        }
    }
}
