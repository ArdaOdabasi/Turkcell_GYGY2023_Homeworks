using AutoMapper;
using FootballLeagueApp.DTOs.Requests.PlayerRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.PlayerResponses;
using FootballLeagueApp.Entities;
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

        public async Task<IEnumerable<PlayerDisplayResponse>> GetAllPlayersAsync()
        {
            var players = await _repository.GetAllAsync();
            var responses = players.ConvertPlayersToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<IEnumerable<PlayerDisplayResponse>> GetPlayersByNationalityAsync(string nationality)
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

        public async Task<int> CreateAndReturnIdAsync(CreateNewPlayerRequest createNewPlayerRequest)
        {
            var player = _mapper.ConvertRequestToPlayer(createNewPlayerRequest);
            await _repository.CreateAsync(player);

            return player.Id;
        }

        public async Task UpdateStatisticIdAsync(int playerId, int newStatisticId)
        {
            await _repository.UpdateStatisticIdAsync(playerId, newStatisticId);
        }

        public async Task<bool> PlayerIsExistsAsync(int playerId)
        {
            return await _repository.IsExistsAsync(playerId);
        }

        public async Task UpdatePlayerAsync(UpdatePlayerRequest updatePlayerRequest)
        {
            var team = _mapper.ConvertUpdateRequestToPlayer(updatePlayerRequest);
            await _repository.UpdateAsync(team);
        }

        public async Task<int> UpdateAndReturnIdAsync(UpdatePlayerRequest updatePlayerRequest)
        {
            var team = _mapper.ConvertUpdateRequestToPlayer(updatePlayerRequest);
            await _repository.UpdateAsync(team);

            return team.Id;
        }

        public async Task<UpdatePlayerRequest> GetPlayerForUpdate(int id)
        {
            var player = await _repository.GetAsync(id);
            return _mapper.ConvertPlayerToUpdateRequest(player);
        }       
    }
}
