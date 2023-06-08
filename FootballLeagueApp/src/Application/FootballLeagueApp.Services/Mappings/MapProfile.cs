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
            CreateMap<User, UserDisplayResponse>();
            CreateMap<Role, RoleDisplayResponse>();
            CreateMap<CreateNewTeamRequest, Team>();
            CreateMap<CreateNewPlayerRequest, Player>();
            CreateMap<CreateNewStatisticRequest, Statistic>();
            CreateMap<CreateNewCoachRequest, Coach>();
            CreateMap<CreateNewMatchRequest, Match>();
            CreateMap<CreateNewStandingRequest, Standing>();
            CreateMap<CreateNewStadiumRequest, Stadium>();
            CreateMap<CreateNewUserRequest, User>();
            CreateMap<CreateNewRoleRequest, Role>();
        }
    }
}
