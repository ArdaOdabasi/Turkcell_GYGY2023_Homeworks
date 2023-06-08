using AutoMapper;
using FootballLeagueApp.DTOs.Requests.PlayerRequests;
using FootballLeagueApp.DTOs.Responses.PlayerResponses;
using FootballLeagueApp.Repositories.PlayerRepository;
using FootballLeagueApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.PlayerService
{
    public class PlayerService : IPlayerService
    {
        private readonly IPlayerRepository _repository;
        private readonly IMapper _mapper;

        public PlayerService(IPlayerRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<PlayerDisplayResponse>> GetAllPlayers()
        {
            var players = await _repository.GetAllAsync();
            var responses = players.ConvertPlayersToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<IEnumerable<PlayerDisplayResponse>> GetPlayersByNationality(string nationality)
        {
            var players = await _repository.GetAllByNationalityAsync(nationality);
            var responses = players.ConvertPlayersToDisplayResponses(_mapper);
            return responses;
        }

        public async Task CreatePlayerAsync(CreateNewPlayerRequest createNewPlayerRequest)
        {
            var player = _mapper.ConvertRequestToPlayer(createNewPlayerRequest);
            await _repository.CreateAsync(player);
        }
    }
}
