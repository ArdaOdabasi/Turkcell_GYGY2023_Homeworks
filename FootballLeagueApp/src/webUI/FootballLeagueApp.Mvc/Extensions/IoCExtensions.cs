using FootballLeagueApp.Infrastructure.Data;
using FootballLeagueApp.Repositories.CoachRepository;
using FootballLeagueApp.Repositories.MatchRepository;
using FootballLeagueApp.Repositories.PlayerRepository;
using FootballLeagueApp.Repositories.StadiumRepository;
using FootballLeagueApp.Repositories.StandingRepository;
using FootballLeagueApp.Repositories.StatisticRepository;
using FootballLeagueApp.Repositories.TeamRepository;
using FootballLeagueApp.Repositories.UserRepository;
using FootballLeagueApp.Services.CoachService;
using FootballLeagueApp.Services.MatchService;
using FootballLeagueApp.Services.PlayerService;
using FootballLeagueApp.Services.StadiumService;
using FootballLeagueApp.Services.StandingService;
using FootballLeagueApp.Services.StatisticService;
using FootballLeagueApp.Services.TeamService;
using FootballLeagueApp.Services.UserService;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace FootballLeagueApp.Mvc.Extensions
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddInjections(this IServiceCollection services)
        {
            services.AddScoped<ITeamService, TeamService>();
            services.AddScoped<ITeamRepository, EFTeamRepository>();
            services.AddScoped<IPlayerService, PlayerService>();
            services.AddScoped<IPlayerRepository, EFPlayerRepository>();
            services.AddScoped<ICoachService, CoachService>();
            services.AddScoped<ICoachRepository, EFCoachRepository>();
            services.AddScoped<IStadiumService, StadiumService>();
            services.AddScoped<IStadiumRepository, EFStadiumRepository>();
            services.AddScoped<IStandingService, StandingService>();
            services.AddScoped<IStandingRepository, EFStandingRepository>();
            services.AddScoped<IMatchService, MatchService>();
            services.AddScoped<IMatchRepository, EFMatchRepository>();
            services.AddScoped<IStatisticService, StatisticService>();
            services.AddScoped<IStatisticRepository, EFStatisticRepository>();
            services.AddDbContext<FootballLeagueDbContext>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, EFUserRepository>();

            return services;
        }
    }
}
