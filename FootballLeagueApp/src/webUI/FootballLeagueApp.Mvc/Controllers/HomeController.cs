using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.Entities;
using FootballLeagueApp.Mvc.Models;
using FootballLeagueApp.Services.CoachService;
using FootballLeagueApp.Services.StadiumService;
using FootballLeagueApp.Services.TeamService;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace FootballLeagueApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ITeamService _teamService;
        private readonly IStadiumService _stadiumService;
        private readonly ICoachService _coachService;

        public HomeController(ILogger<HomeController> logger, ITeamService teamService, IStadiumService stadiumService, ICoachService coachService)
        {
            _logger = logger;
            _teamService = teamService;
            _stadiumService = stadiumService;
            _coachService = coachService;
        }

        public async Task<IActionResult> Index()
        {
            var teams = await _teamService.GetAllTeams();
            return View(teams);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Coaches = await GetCoachesForSelectList();
            ViewBag.Stadiums = await GetStadiumsForSelectList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewTeamRequest request)
        {
            if (ModelState.IsValid)
            {
                await _teamService.CreateTeamAsync(request);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Coaches = await GetCoachesForSelectList();
            ViewBag.Stadiums = await GetStadiumsForSelectList();
            return View();
        }

        private async Task<IEnumerable<SelectListItem>> GetCoachesForSelectList()
        {
            var coaches = await _coachService.GetAllCoaches();
            var selectList = coaches.Select(c => new SelectListItem { Text = c.FirstName, Value = c.Id.ToString() }).ToList();
            return selectList;
        }

        private async Task<IEnumerable<SelectListItem>> GetStadiumsForSelectList()
        {
            var stadiums = await _stadiumService.GetAllStadiums();
            var selectList = stadiums.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return selectList;
        }
   
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}