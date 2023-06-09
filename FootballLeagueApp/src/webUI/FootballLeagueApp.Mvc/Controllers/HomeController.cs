using Azure.Core;
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
            var teams = await _teamService.GetAllTeamsAsync();
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
                int teamId = await _teamService.CreateAndReturnIdAsync(request);

                if (request.StadiumId.HasValue)
                {
                    await _stadiumService.UpdateTeamIdAsync(request.StadiumId.Value, teamId);
                }

                if (request.CoachId.HasValue)
                {
                    await _coachService.UpdateTeamIdAsync(request.CoachId.Value, teamId);
                }

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Coaches = await GetCoachesForSelectList();
            ViewBag.Stadiums = await GetStadiumsForSelectList();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Coaches = await GetCoachesForSelectList();
            ViewBag.Stadiums = await GetStadiumsForSelectList();
            var team = await _teamService.GetTeamForUpdate(id);

            return View(team);        
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, UpdateTeamRequest updateTeamRequest)
        {
            if (await _teamService.TeamIsExistsAsync(id))
            {
                if (ModelState.IsValid)
                {
                    int teamId = await _teamService.UpdateAndReturnIdAsync(updateTeamRequest);

                    if (updateTeamRequest.StadiumId.HasValue)
                    {
                        await _stadiumService.UpdateTeamIdAsync(updateTeamRequest.StadiumId.Value, teamId);
                    }

                    if (updateTeamRequest.CoachId.HasValue)
                    {
                        await _coachService.UpdateTeamIdAsync(updateTeamRequest.CoachId.Value, teamId);
                    }

                    return RedirectToAction(nameof(Index));
                }
                ViewBag.Coaches = await GetCoachesForSelectList();
                ViewBag.Stadiums = await GetStadiumsForSelectList();
                return View();
            }
            return NotFound();
        }

        private async Task<IEnumerable<SelectListItem>> GetCoachesForSelectList()
        {
            var coaches = await _coachService.GetCoachesWithoutTeamAsync();
            var selectList = coaches.Select(c => new SelectListItem { Text = c.FirstName, Value = c.Id.ToString() }).ToList();
            return selectList;
        }

        private async Task<IEnumerable<SelectListItem>> GetStadiumsForSelectList()
        {
            var stadiums = await _stadiumService.GetStadiumsWithoutTeamAsync();
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