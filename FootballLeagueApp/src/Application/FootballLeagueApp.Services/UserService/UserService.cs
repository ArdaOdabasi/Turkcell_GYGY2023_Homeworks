using AutoMapper;
using FootballLeagueApp.DTOs.Requests.UserRequests;
using FootballLeagueApp.DTOs.Responses.UserRequests;
using FootballLeagueApp.Entities;
using FootballLeagueApp.Repositories.UserRepository;
using FootballLeagueApp.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Services.UserService
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UserDisplayResponse>> GetAllUsersAsync()
        {
            var users = await _repository.GetAllAsync();
            var responses = users.ConvertUsersToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<User?> ValidateUserAsync(string username, string password)
        {
            var users = await _repository.GetAllAsync();
            return users.SingleOrDefault(u => u.UserName == username && u.Password == password);
        }

        public async Task CreateUserAsync(CreateNewUserRequest createNewUserRequest)
        {
            var user = _mapper.ConvertRequestToUser(createNewUserRequest);
            await _repository.CreateAsync(user);
        }

        public async Task<bool> UserIsExistsAsync(int userId)
        {
            return await _repository.IsExistsAsync(userId);
        }

        public async Task UpdateUserAsync(UpdateUserRequest updateUserRequest)
        {
            var user = _mapper.ConvertUpdateRequestToUser(updateUserRequest);
            await _repository.UpdateAsync(user);
        }

        public async Task<UpdateUserRequest> GetUserForUpdate(int id)
        {
            var user = await _repository.GetAsync(id);
            return _mapper.ConvertUserToUpdateRequest(user);
        }
    }
}
