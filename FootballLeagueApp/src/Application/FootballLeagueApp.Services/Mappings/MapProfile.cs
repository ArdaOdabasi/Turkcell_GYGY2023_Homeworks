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

namespace FootballLeagueApp.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Team, TeamDisplayResponse>();
            CreateMap<Player, PlayerDisplayResponse>();
            CreateMap<Statistic, StatisticDisplayResponse>();
            CreateMap<Coach, CoachDisplayResponse>();
            CreateMap<Match, MatchDisplayResponse>();
            CreateMap<Standing, StandingDisplayResponse>();
            CreateMap<Stadium, StadiumDisplayResponse>();
        }
    }
}
