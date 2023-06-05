using FootballLeagueApp.Services.CoachService;
using FootballLeagueApp.Services.PlayerService;
using Microsoft.AspNetCore.Mvc;

namespace FootballLeagueApp.Mvc.Controllers
{
    public class CoachController : Controller
    {
        private readonly ILogger<CoachController> _logger;
        private readonly ICoachService _coachService;

        public CoachController(ILogger<CoachController> logger, ICoachService coachService)
        {
            _logger = logger;
            _coachService = coachService;
        }

        public async Task<IActionResult> Index()
        {
            var coaches = await _coachService.GetAllCoaches();
            return View(coaches);
        }
    }
}
