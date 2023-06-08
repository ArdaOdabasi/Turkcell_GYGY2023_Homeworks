﻿using AutoMapper;
using FootballLeagueApp.DTOs.Requests.StandingRequests;
using FootballLeagueApp.DTOs.Responses.StandingResponses;
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

        public async Task<IEnumerable<StandingDisplayResponse>> GetAllStandings()
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

        public async Task<IEnumerable<StandingDisplayResponse>> GetAllStandingsOrderedByScore()
        {
            var standings = await _repository.GetAllStandingsOrderedByScore();
            var responses = standings.ConvertStandingsToDisplayResponses(_mapper);
            return responses;
        }
    }
}
