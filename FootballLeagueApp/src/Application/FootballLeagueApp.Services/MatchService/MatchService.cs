using AutoMapper;
using FootballLeagueApp.DTOs.Requests.MatchRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.MatchResponses;
using FootballLeagueApp.Entities;
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

        public async Task<IEnumerable<MatchDisplayResponse>> GetAllMatchesAsync()
        {
            var matches = await _repository.GetAllAsync();
            var responses = matches.ConvertMatchesToDisplayResponses(_mapper);
            return responses;
        }

        public async Task CreateMatchAsync(CreateNewMatchRequest createNewMatchRequest)
        {
            var match = _mapper.ConvertRequestToMatch(createNewMatchRequest);
            await _repository.CreateAsync(match);
        }

        public async Task<bool> MatchIsExistsAsync(int matchId)
        {
            return await _repository.IsExistsAsync(matchId);
        }

        public async Task UpdateMatchAsync(UpdateMatchRequest updateMatchRequest)
        {
            var team = _mapper.ConvertUpdateRequestToMatch(updateMatchRequest);
            await _repository.UpdateAsync(team);
        }

        public async Task<UpdateMatchRequest> GetMatchForUpdate(int id)
        {
            var match = await _repository.GetAsync(id);
            return _mapper.ConvertMatchToUpdateRequest(match);
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
