using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.Mvc.Models;
using FootballLeagueApp.Services.TeamService;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FootballLeagueApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITeamService _teamService;

        public HomeController(ILogger<HomeController> logger, ITeamService teamService)
        {
            _logger = logger;
            _teamService = teamService;
        }

        public async Task<IActionResult> Index()
        {
            var teams = await _teamService.GetAllTeams();
            return View(teams);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}