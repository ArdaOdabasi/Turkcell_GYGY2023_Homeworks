using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.Mvc.Models;
using FootballLeagueApp.Services.StadiumService;
using FootballLeagueApp.Services.StandingService;
using FootballLeagueApp.Services.TeamService;
using Microsoft.AspNetCore.Mvc;

namespace FootballLeagueApp.Mvc.Controllers
{
    public class StandingController : Controller
    {
        private readonly ILogger<StandingController> _logger;
        private readonly IStandingService _standingService;
        private readonly ITeamService _teamService;

        public StandingController(ILogger<StandingController> logger, IStandingService standingService, ITeamService teamService)
        {
            _logger = logger;
            _standingService = standingService;
            _teamService = teamService;
        }

        public async Task<IActionResult> Index()
        {
            var standings = await _standingService.GetAllStandings();

            List<TeamDisplayResponse> teams = new List<TeamDisplayResponse>();

            TeamDisplayResponse team;

            foreach (var standing in standings)
            {
                team = await _teamService.GetTeamById(standing.Id);
                teams.Add(team);
            }

            var model = new AllStandingsViewModel
            {
                standings = standings,
                teams = teams
            };

            return View(model);
        }
    }
}
