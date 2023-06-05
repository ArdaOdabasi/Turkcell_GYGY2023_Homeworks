using FootballLeagueApp.Services.PlayerService;
using Microsoft.AspNetCore.Mvc;

namespace FootballLeagueApp.Mvc.ViewComponents
{
    public class ComboBoxViewComponent : ViewComponent
    {
        private readonly IPlayerService playerService;

        public ComboBoxViewComponent(IPlayerService playerService)
        {
            this.playerService = playerService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var players = await playerService.GetAllPlayers();
            return View(players);
        }
    }
}
