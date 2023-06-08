using FootballLeagueApp.DTOs.Requests.CoachRequests;
using FootballLeagueApp.DTOs.Requests.StadiumRequests;
using FootballLeagueApp.Services.CoachService;
using FootballLeagueApp.Services.PlayerService;
using FootballLeagueApp.Services.TeamService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FootballLeagueApp.Mvc.Controllers
{
    public class CoachController : Controller
    {
        private readonly ILogger<CoachController> _logger;
        private readonly ICoachService _coachService;
        private readonly ITeamService _teamService;

        public CoachController(ILogger<CoachController> logger, ICoachService coachService, ITeamService teamService)
        {
            _logger = logger;
            _coachService = coachService;
            _teamService = teamService;
        }

        public async Task<IActionResult> Index()
        {
            var coaches = await _coachService.GetAllCoaches();
            return View(coaches);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Teams = await GetTeamsForSelectList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewCoachRequest request)
        {
            if (ModelState.IsValid)
            {
                await _coachService.CreateCoachAsync(request);
                return RedirectToAction(nameof(Index));
            }

            ViewBag.Teams = await GetTeamsForSelectList();
            return View();
        }

        private async Task<IEnumerable<SelectListItem>> GetTeamsForSelectList()
        {
            var teams = await _teamService.GetAllTeams();
            var selectList = teams.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return selectList;
        }
    }
}
