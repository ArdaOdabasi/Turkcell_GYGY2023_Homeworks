using AutoMapper;
using FootballLeagueApp.DTOs.Requests.CoachRequests;
using FootballLeagueApp.DTOs.Requests.MatchRequests;
using FootballLeagueApp.DTOs.Requests.PlayerRequests;
using FootballLeagueApp.DTOs.Requests.RoleRequests;
using FootballLeagueApp.DTOs.Requests.StadiumRequests;
using FootballLeagueApp.DTOs.Requests.StandingRequests;
using FootballLeagueApp.DTOs.Requests.StatisticRequests;
using FootballLeagueApp.DTOs.Requests.TeamRequests;
using FootballLeagueApp.DTOs.Requests.UserRequests;
using FootballLeagueApp.DTOs.Responses.CoachResponses;
using FootballLeagueApp.DTOs.Responses.MatchResponses;
using FootballLeagueApp.DTOs.Responses.PlayerResponses;
using FootballLeagueApp.DTOs.Responses.RoleRequests;
using FootballLeagueApp.DTOs.Responses.StadiumResponses;
using FootballLeagueApp.DTOs.Responses.StandingResponses;
using FootballLeagueApp.DTOs.Responses.StatisticResponses;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
using FootballLeagueApp.DTOs.Responses.UserRequests;
using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.Extensions
{
    public static class MappingExtensions
    {
        public static IEnumerable<TeamDisplayResponse> ConvertTeamsToDisplayResponses(this IEnumerable<Team> teams, IMapper mapper)
        {
            return mapper.Map<IEnumerable<TeamDisplayResponse>>(teams);
        }

        public static TeamDisplayResponse ConvertTeamToDisplayResponses(this Team team, IMapper mapper)
        {
            return mapper.Map<TeamDisplayResponse>(team);
        }

        public static Team ConvertRequestToTeam(this IMapper mapper, CreateNewTeamRequest createNewTeamRequest)
        {
            return mapper.Map<Team>(createNewTeamRequest);
        }

        public static IEnumerable<PlayerDisplayResponse> ConvertPlayersToDisplayResponses(this IEnumerable<Player> players, IMapper mapper)
        {
            return mapper.Map<IEnumerable<PlayerDisplayResponse>>(players);
        }

        public static Player ConvertRequestToPlayer(this IMapper mapper, CreateNewPlayerRequest createNewPlayerRequest)
        {
            return mapper.Map<Player>(createNewPlayerRequest);
        }

        public static IEnumerable<StatisticDisplayResponse> ConvertStatisticsToDisplayResponses(this IEnumerable<Statistic> statistics, IMapper mapper)
        {
            return mapper.Map<IEnumerable<StatisticDisplayResponse>>(statistics);
        }

        public static StatisticDisplayResponse ConvertStatisticToDisplayResponses(this Statistic statistic, IMapper mapper)
        {
            return mapper.Map<StatisticDisplayResponse>(statistic);
        }

        public static Statistic ConvertRequestToStatistic(this IMapper mapper, CreateNewStatisticRequest createNewStatisticRequest)
        {
            return mapper.Map<Statistic>(createNewStatisticRequest);
        }

        public static IEnumerable<CoachDisplayResponse> ConvertCoachesToDisplayResponses(this IEnumerable<Coach> coaches, IMapper mapper)
        {
            return mapper.Map<IEnumerable<CoachDisplayResponse>>(coaches);
        }

        public static Coach ConvertRequestToCoach(this IMapper mapper, CreateNewCoachRequest createNewCoachRequest)
        {
            return mapper.Map<Coach>(createNewCoachRequest);
        }

        public static IEnumerable<MatchDisplayResponse> ConvertMatchesToDisplayResponses(this IEnumerable<Match> matches, IMapper mapper)
        {
            return mapper.Map<IEnumerable<MatchDisplayResponse>>(matches);
        }

        public static Match ConvertRequestToMatch(this IMapper mapper, CreateNewMatchRequest createNewMatchRequest)
        {
            return mapper.Map<Match>(createNewMatchRequest);
        }

        public static IEnumerable<StandingDisplayResponse> ConvertStandingsToDisplayResponses(this IEnumerable<Standing> standings, IMapper mapper)
        {
            return mapper.Map<IEnumerable<StandingDisplayResponse>>(standings);
        }

        public static Standing ConvertRequestToStanding(this IMapper mapper, CreateNewStandingRequest createNewStandingRequest)
        {
            return mapper.Map<Standing>(createNewStandingRequest);
        }

        public static IEnumerable<StadiumDisplayResponse> ConvertStadiumsToDisplayResponses(this IEnumerable<Stadium> stadiums, IMapper mapper)
        {
            return mapper.Map<IEnumerable<StadiumDisplayResponse>>(stadiums);
        }

        public static StadiumDisplayResponse ConvertStadiumToDisplayResponses(this Stadium stadium, IMapper mapper)
        {
            return mapper.Map<StadiumDisplayResponse>(stadium);
        }

        public static Stadium ConvertRequestToStadium(this IMapper mapper, CreateNewStadiumRequest createNewStadiumRequest)
        {
            return mapper.Map<Stadium>(createNewStadiumRequest);
        }

        public static IEnumerable<UserDisplayResponse> ConvertUsersToDisplayResponses(this IEnumerable<User> users, IMapper mapper)
        {
            return mapper.Map<IEnumerable<UserDisplayResponse>>(users);
        }

        public static User ConvertRequestToUser(this IMapper mapper, CreateNewUserRequest createNewUserRequest)
        {
            return mapper.Map<User>(createNewUserRequest);
        }

        public static IEnumerable<RoleDisplayResponse> ConvertRolesToDisplayResponses(this IEnumerable<Role> roles, IMapper mapper)
        {
            return mapper.Map<IEnumerable<RoleDisplayResponse>>(roles);
        }

        public static Role ConvertRequestToRole(this IMapper mapper, CreateNewRoleRequest createNewRoleRequest)
        {
            return mapper.Map<Role>(createNewRoleRequest);
        }
    }
}
