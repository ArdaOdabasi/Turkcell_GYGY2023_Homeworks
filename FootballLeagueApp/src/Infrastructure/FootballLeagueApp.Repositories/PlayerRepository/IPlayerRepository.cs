﻿using FootballLeagueApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Repositories.PlayerRepository
{
    public interface IPlayerRepository : IRepository<Player>
    {
        Task<IList<Player?>> GetAllByNationalityAsync(string nationality);
        Task<int> CreateAndReturnIdAsync(Player entity);
        Task<int> UpdateAndReturnIdAsync(Player entity);
        Task UpdateStatisticIdAsync(int playerId, int newStatisticId);
    }
}
