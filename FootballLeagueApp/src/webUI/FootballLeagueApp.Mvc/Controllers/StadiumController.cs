using FootballLeagueApp.DTOs.Requests.StadiumRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.Services.CoachService;
using FootballLeagueApp.Services.StadiumService;
using FootballLeagueApp.Services.TeamService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FootballLeagueApp.Mvc.Controllers
{
    public class StadiumController : Controller
    {
        private readonly ILogger<StadiumController> _logger;
        private readonly IStadiumService _stadiumService;
        private readonly ITeamService _teamService;

        public StadiumController(ILogger<StadiumController> logger, IStadiumService stadiumService, ITeamService teamService)
        {
            _logger = logger;
            _stadiumService = stadiumService;
            _teamService = teamService;
        }

        public async Task<IActionResult> Index()
        {
            var stadiums = await _stadiumService.GetAllStadiums();
            return View(stadiums);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewBag.Teams = await GetTeamsForSelectList();         
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewStadiumRequest request)
        {
            if (ModelState.IsValid)
            {
                await _stadiumService.CreateStadiumAsync(request);
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
