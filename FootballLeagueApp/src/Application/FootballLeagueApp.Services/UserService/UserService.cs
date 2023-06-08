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

        public async Task<IEnumerable<UserDisplayResponse>> GetAllUsers()
        {
            var users = await _repository.GetAllAsync();
            var responses = users.ConvertUsersToDisplayResponses(_mapper);
            return responses;
        }

        public async Task<User?> ValidateUser(string username, string password)
        {
            var users = await _repository.GetAllAsync();
            return users.SingleOrDefault(u => u.UserName == username && u.Password == password);
        }

        public async Task CreateUserAsync(CreateNewUserRequest createNewUserRequest)
        {
            var user = _mapper.ConvertRequestToUser(createNewUserRequest);
            await _repository.CreateAsync(user);
        }
    }
}
