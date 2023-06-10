using FootballLeagueApp.Mvc.Models;
using FootballLeagueApp.Services.UserService;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace FootballLeagueApp.Mvc.Controllers
{
    public class UserController : Controller
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserService _userService;

        public UserController(ILogger<UserController> logger, IUserService userService)
        {
            _logger = logger;
            _userService = userService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Login(string? ReturnUrlParameter)
        {
            ViewBag.ReturnUrl = ReturnUrlParameter;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginViewModel userLogin, string? ReturnUrlParameter)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.ValidateUserAsync(userLogin.UserName, userLogin.Password);
                if (user != null)
                {
                    Claim[] claims = new Claim[]
                    {
                        new Claim(ClaimTypes.Name,user.FirstName),
                    };
                    ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                    ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                    await HttpContext.SignInAsync(principal);

                    if (!string.IsNullOrEmpty(ReturnUrlParameter) && Url.IsLocalUrl(ReturnUrlParameter))
                    {
                        return Redirect(ReturnUrlParameter);
                    }
                    return Redirect("/");

                }
                ModelState.AddModelError("login", "Kullanıcı adı ya da şifre yanlış!");
            }

            return View();
        }

        public IActionResult SignUp(string? ReturnUrlParameter)
        {
            ViewBag.ReturnUrl = ReturnUrlParameter;
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
        }

        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
