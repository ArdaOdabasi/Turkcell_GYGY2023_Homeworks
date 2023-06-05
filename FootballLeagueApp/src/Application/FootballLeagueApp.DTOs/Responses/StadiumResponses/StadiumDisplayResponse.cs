using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Responses.StadiumResponses
{
    public class StadiumDisplayResponse
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string Address { get; set; } = string.Empty;
    }
}
