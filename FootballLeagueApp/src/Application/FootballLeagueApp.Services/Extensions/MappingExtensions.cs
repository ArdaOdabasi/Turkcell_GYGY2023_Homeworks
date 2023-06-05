using AutoMapper;
using FootballLeagueApp.DTOs.Responses.CoachResponses;
using FootballLeagueApp.DTOs.Responses.MatchResponses;
using FootballLeagueApp.DTOs.Responses.PlayerResponses;
using FootballLeagueApp.DTOs.Responses.StadiumResponses;
using FootballLeagueApp.DTOs.Responses.StandingResponses;
using FootballLeagueApp.DTOs.Responses.StatisticResponses;
using FootballLeagueApp.DTOs.Responses.TeamResponses;
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

        public static IEnumerable<PlayerDisplayResponse> ConvertPlayersToDisplayResponses(this IEnumerable<Player> players, IMapper mapper)
        {
            return mapper.Map<IEnumerable<PlayerDisplayResponse>>(players);
        }

        public static IEnumerable<StatisticDisplayResponse> ConvertStatisticsToDisplayResponses(this IEnumerable<Statistic> statistics, IMapper mapper)
        {
            return mapper.Map<IEnumerable<StatisticDisplayResponse>>(statistics);
        }

        public static StatisticDisplayResponse ConvertStatisticToDisplayResponses(this Statistic statistic, IMapper mapper)
        {
            return mapper.Map<StatisticDisplayResponse>(statistic);
        }

        public static IEnumerable<CoachDisplayResponse> ConvertCoachesToDisplayResponses(this IEnumerable<Coach> coaches, IMapper mapper)
        {
            return mapper.Map<IEnumerable<CoachDisplayResponse>>(coaches);
        }

        public static IEnumerable<MatchDisplayResponse> ConvertMatchesToDisplayResponses(this IEnumerable<Match> matches, IMapper mapper)
        {
            return mapper.Map<IEnumerable<MatchDisplayResponse>>(matches);
        }
   
        public static IEnumerable<StandingDisplayResponse> ConvertStandingsToDisplayResponses(this IEnumerable<Standing> standings, IMapper mapper)
        {
            return mapper.Map<IEnumerable<StandingDisplayResponse>>(standings);
        }

        public static IEnumerable<StadiumDisplayResponse> ConvertStadiumsToDisplayResponses(this IEnumerable<Stadium> stadiums, IMapper mapper)
        {
            return mapper.Map<IEnumerable<StadiumDisplayResponse>>(stadiums);
        }

        public static StadiumDisplayResponse ConvertStadiumToDisplayResponses(this Stadium stadium, IMapper mapper)
        {
            return mapper.Map<StadiumDisplayResponse>(stadium);
        }
    }
}
