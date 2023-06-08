using FootballLeagueApp.DTOs.Requests.UserRequests;
using FootballLeagueApp.DTOs.Responses.UserRequests;
using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.UserService
{
    public interface IUserService
    {
        Task<IEnumerable<UserDisplayResponse>> GetAllUsers();
        Task<User?> ValidateUser(string username, string password);
        Task CreateUserAsync(CreateNewUserRequest createNewUserRequest);
    }
}
