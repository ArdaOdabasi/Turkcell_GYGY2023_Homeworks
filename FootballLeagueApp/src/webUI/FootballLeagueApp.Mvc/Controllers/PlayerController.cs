using FootballLeagueApp.DTOs.Responses.PlayerResponses;
using FootballLeagueApp.DTOs.Responses.StatisticResponses;
using FootballLeagueApp.Entities;
using FootballLeagueApp.Mvc.Models;
using FootballLeagueApp.Services.PlayerService;
using FootballLeagueApp.Services.StatisticService;
using FootballLeagueApp.Services.TeamService;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Text.Json;

namespace FootballLeagueApp.Mvc.Controllers
{
    public class PlayerController : Controller
    {
        private readonly ILogger<PlayerController> _logger;
        private readonly IPlayerService _playerService;
        private readonly IStatisticService _statisticService;

        public PlayerController(ILogger<PlayerController> logger, IPlayerService playerService, IStatisticService statisticService)
        {
            _logger = logger;
            _playerService = playerService;
            _statisticService = statisticService;
        }

        public async Task<IActionResult> Index(string id)
        {
            var players = id == null ? await _playerService.GetAllPlayers() :
                                                await _playerService.GetPlayersByNationality(id);

            List<StatisticDisplayResponse> statistics = new List<StatisticDisplayResponse>();

            StatisticDisplayResponse statistic;

            foreach (var player in players)
            {
                statistic = await _statisticService.GetStatisticById(player.Id);
                statistics.Add(statistic);
            }

            var model = new AllPlayersViewModel
            {
                players = players,
                statistics = statistics
            };

            return View(model);
        }
    }
}
