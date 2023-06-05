using FootballLeagueApp.Services.CoachService;
using FootballLeagueApp.Services.StadiumService;
using Microsoft.AspNetCore.Mvc;

namespace FootballLeagueApp.Mvc.Controllers
{
    public class StadiumController : Controller
    {
        private readonly ILogger<StadiumController> _logger;
        private readonly IStadiumService _stadiumService;

        public StadiumController(ILogger<StadiumController> logger, IStadiumService stadiumService)
        {
            _logger = logger;
            _stadiumService = stadiumService;
        }

        public async Task<IActionResult> Index()
        {
            var stadiums = await _stadiumService.GetAllStadiums();
            return View(stadiums);
        }
    }
}
