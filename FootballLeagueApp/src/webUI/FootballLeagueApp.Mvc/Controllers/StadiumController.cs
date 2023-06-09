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
            var stadiums = await _stadiumService.GetAllStadiumsAsync();
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
                int stadiumId = await _stadiumService.CreateAndReturnIdAsync(request);

                if (request.TeamId.HasValue)
                {
                    await _teamService.UpdateStadiumIdAsync(request.TeamId.Value, stadiumId);
                }

                return RedirectToAction(nameof(Index));
            }

            ViewBag.Teams = await GetTeamsForSelectList();
            return View();
        }

        private async Task<IEnumerable<SelectListItem>> GetTeamsForSelectList()
        {
            var teams = await _teamService.GetTeamsWithoutStadiumAsync();
            var selectList = teams.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() }).ToList();
            return selectList;
        }
    }
}
