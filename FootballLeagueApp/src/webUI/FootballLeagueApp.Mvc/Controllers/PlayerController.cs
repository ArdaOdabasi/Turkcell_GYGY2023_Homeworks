using Azure.Core;
using FootballLeagueApp.DTOs.Requests.MatchRequests;
using FootballLeagueApp.DTOs.Requests.PlayerRequests;
using FootballLeagueApp.DTOs.Responses.PlayerResponses;
using FootballLeagueApp.DTOs.Responses.StatisticResponses;
using FootballLeagueApp.Entities;
using FootballLeagueApp.Mvc.Models;
using FootballLeagueApp.Services.PlayerService;
using FootballLeagueApp.Services.StatisticService;
using FootballLeagueApp.Services.TeamService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Text.Json;

namespace FootballLeagueApp.Mvc.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ILogger<PlayerController> _logger;
        private readonly IPlayerService _playerService;
        private readonly IStatisticService _statisticService;
        private readonly ITeamService _teamService;

        public PlayerController(ILogger<PlayerController> logger, IPlayerService playerService, IStatisticService statisticService, ITeamService teamService)
        {
            _logger = logger;
            _playerService = playerService;
            _statisticService = statisticService;
            _teamService = teamService;
        }

        public async Task<IActionResult> Index(string id)
        {
            var players = id == null ? await _playerService.GetAllPlayersAsync() :
                                       await _playerService.GetPlayersByNationalityAsync(id);

            List<StatisticDisplayResponse> statistics = new List<StatisticDisplayResponse>();

            StatisticDisplayResponse statistic;

            foreach (var player in players)
            {
                statistic = await _statisticService.GetStatisticByPlayerIdAsync(player.Id);
                statistics.Add(statistic);
            }

            var teamIds = players.Select(player => player.TeamId).Distinct().ToList();
            var teamNames = new Dictionary<int, string>();

            foreach (var teamId in teamIds)
            {
                var team = teamId.HasValue ? await _teamService.GetTeamByIdAsync(teamId.Value) : null;
                teamNames.Add(teamId.HasValue ? teamId.Value : 0, team?.Name ?? "Takımı Yok");
            }

            var model = new AllPlayersViewModel
            {
                players = players,
                statistics = statistics,
                teamNames = teamNames
            };

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Teams = await GetTeamsForSelectList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewPlayerAndStatistic createNewPlayerAndStatistic)
        {
            if (ModelState.IsValid)
            {
                var createNewPlayer = createNewPlayerAndStatistic.createNewPlayerRequest;
                var createNewStatistic = createNewPlayerAndStatistic.createNewStatisticRequest;
                
                int playerId = await _playerService.CreateAndReturnIdAsync(createNewPlayer);

                int statisticId = await _statisticService.CreateAndReturnIdAsync(createNewStatistic);

                await _statisticService.UpdatePlayerIdAsync(statisticId, playerId);

                await _playerService.UpdateStatisticIdAsync(playerId, statisticId);

                return RedirectToAction(nameof(Index));
            }
     
            ViewBag.Teams = await GetTeamsForSelectList();
            return View();
        }
   
        private async Task<IEnumerable<SelectListItem>> GetTeamsForSelectList()
        {
            var teams = await _teamService.GetAllTeamsAsync();
            var selectList = teams.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return selectList;
        }
    }
}
