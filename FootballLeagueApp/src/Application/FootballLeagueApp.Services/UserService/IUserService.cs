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
        Task<IEnumerable<UserDisplayResponse>> GetAllUsersAsync();
        Task<User?> ValidateUserAsync(string username, string password);
        Task CreateUserAsync(CreateNewUserRequest createNewUserRequest);
        Task<bool> UserIsExistsAsync(int userId);
        Task UpdateUserAsync(UpdateUserRequest updateUserRequest);
        Task<UpdateUserRequest> GetUserForUpdate(int id);
    }
}
