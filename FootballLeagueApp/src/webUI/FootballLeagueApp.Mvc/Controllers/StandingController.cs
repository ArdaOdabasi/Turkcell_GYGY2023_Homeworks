using FootballLeagueApp.DTOs.Requests.MatchRequests;
using FootballLeagueApp.DTOs.Requests.StandingRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.Entities;
using FootballLeagueApp.Mvc.Models;
using FootballLeagueApp.Services.StadiumService;
using FootballLeagueApp.Services.StandingService;
using FootballLeagueApp.Services.TeamService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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
            var standings = await _standingService.GetAllStandingsOrderedByScoreAsync();

            List<TeamDisplayResponse> teams = new List<TeamDisplayResponse>();

            TeamDisplayResponse team;

            foreach (var standing in standings)
            {
                team = await _teamService.GetTeamByIdAsync(standing.TeamId.GetValueOrDefault());
                teams.Add(team);
            }

            var model = new AllStandingsViewModel
            {
                standings = standings,
                teams = teams
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
        public async Task<IActionResult> Create(CreateNewStandingRequest request)
        {
            if (ModelState.IsValid)
            {
                await _standingService.CreateStandingAsync(request);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Teams = await GetTeamsForSelectList();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {         
            var standing = await _standingService.GetStandingForUpdate(id);
            return View(standing);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, UpdateStandingRequest updateStandingRequest)
        {
            if (await _standingService.StandingIsExistsAsync(id))
            {
                if (ModelState.IsValid)
                {
                    await _standingService.UpdateStandingAsync(updateStandingRequest);
              
                    return RedirectToAction(nameof(Index));
                }
                return View();
            }
            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> Delete()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _standingService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

        private async Task<IEnumerable<SelectListItem>> GetTeamsForSelectList()
        {   
            var standings = await _standingService.GetAllStandingsAsync();
            var teams = await _teamService.GetAllTeamsAsync();

            var existingTeamIds = standings.Select(s => s.TeamId).ToList();
            var filteredTeams = teams.Where(t => !existingTeamIds.Contains(t.Id));

            var selectList = filteredTeams.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return selectList;
        }
    }
}
