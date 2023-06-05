﻿using FootballLeagueApp.DTOs.Responses.StadiumResponses;
using FootballLeagueApp.DTOs.Responses.StatisticResponses;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.Entities;
using FootballLeagueApp.Mvc.Models;
using FootballLeagueApp.Services.MatchService;
using FootballLeagueApp.Services.PlayerService;
using FootballLeagueApp.Services.StadiumService;
using FootballLeagueApp.Services.TeamService;
using Microsoft.AspNetCore.Mvc;
using System.Numerics;

namespace FootballLeagueApp.Mvc.Controllers
{
    public class MatchController : Controller
    {
        private readonly ILogger<MatchController> _logger;
        private readonly IMatchService _matchService;
        private readonly ITeamService _teamService;
        private readonly IStadiumService _stadiumService;

        public MatchController(ILogger<MatchController> logger, IMatchService matchService, IStadiumService stadiumService, ITeamService teamService)
        {
            _logger = logger;
            _matchService = matchService;
            _stadiumService = stadiumService;
            _teamService = teamService;
        }

        public async Task<IActionResult> Index()
        {
            var matches = await _matchService.GetAllMatches();

            List<TeamDisplayResponse> homeTeams = new List<TeamDisplayResponse>();
            List<TeamDisplayResponse> awayTeams = new List<TeamDisplayResponse>();
            List<StadiumDisplayResponse> stadiums = new List<StadiumDisplayResponse>();

            TeamDisplayResponse homeTeam;
            TeamDisplayResponse awayTeam;
            StadiumDisplayResponse stadium;

            foreach (var match in matches)
            {
                if (match.HomeTeamId.HasValue)
                {
                    homeTeam = await _teamService.GetTeamById(match.HomeTeamId.Value);
                }
                else
                {
                    homeTeam = null;
                }
                homeTeams.Add(homeTeam);

                if (match.AwayTeamId.HasValue)
                {
                    awayTeam = await _teamService.GetTeamById(match.AwayTeamId.Value);
                }
                else
                {
                    awayTeam = null;
                }
                awayTeams.Add(awayTeam);

                if (match.StadiumId.HasValue)
                {
                    stadium = await _stadiumService.GetStadiumById(match.StadiumId.Value);
                }
                else
                {
                    stadium = null;
                }
                stadiums.Add(stadium);
            }

            var model = new AllMatchesViewModel
            {
                matches = matches,
                homeTeams = homeTeams,
                awayTeams = awayTeams,
                stadiums = stadiums,
            };

            return View(model);
        }
    }
}
