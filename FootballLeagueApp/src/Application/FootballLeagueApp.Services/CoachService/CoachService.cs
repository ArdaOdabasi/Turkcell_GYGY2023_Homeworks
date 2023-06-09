using AutoMapper;
using FootballLeagueApp.DTOs.Requests.CoachRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.CoachResponses;
using FootballLeagueApp.Entities;
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

        public async Task<IEnumerable<CoachDisplayResponse>> GetAllCoachesAsync()
        {
            var coaches = await _repository.GetAllAsync();
            var responses = coaches.ConvertCoachesToDisplayResponses(_mapper);
            return responses;
        }

        public async Task CreateCoachAsync(CreateNewCoachRequest createNewCoachRequest)
        {
            var coach = _mapper.ConvertRequestToCoach(createNewCoachRequest);
            await _repository.CreateAsync(coach);
        }

        public async Task<IEnumerable<CoachDisplayResponse>> GetCoachesWithoutTeamAsync()
        {
            var coaches = await _repository.GetCoachesWithoutTeamAsync();
            var responses = coaches.ConvertCoachesToDisplayResponses(_mapper);
            return responses;
        }

        public async Task UpdateTeamIdAsync(int coachId, int newTeamId)
        {
            await _repository.UpdateTeamIdAsync(coachId, newTeamId);
        }

        public async Task<int> CreateAndReturnIdAsync(CreateNewCoachRequest createNewCoachRequest)
        {
            var coach = _mapper.ConvertRequestToCoach(createNewCoachRequest);
            await _repository.CreateAsync(coach);

            return coach.Id;
        }

        public async Task<bool> CoachIsExistsAsync(int coachId)
        {
            return await _repository.IsExistsAsync(coachId);
        }

        public async Task UpdateCoachAsync(UpdateCoachRequest updateCoachRequest)
        {
            var team = _mapper.ConvertUpdateRequestToCoach(updateCoachRequest);
            await _repository.UpdateAsync(team);
        }

        public async Task<int> UpdateAndReturnIdAsync(UpdateCoachRequest updateCoachRequest)
        {
            var team = _mapper.ConvertUpdateRequestToCoach(updateCoachRequest);
            await _repository.UpdateAsync(team);

            return team.Id;
        }

        public async Task<UpdateCoachRequest> GetCoachForUpdate(int id)
        {
            var coach = await _repository.GetAsync(id);
            return _mapper.ConvertCoachToUpdateRequest(coach);         
        }

        public async Task DeleteAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}
