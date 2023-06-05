using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.DTOs.Responses.StatisticResponses
{
    public class StatisticDisplayResponse
    {
        public int Id { get; set; }
        public int Match { get; set; }
        public int Goal { get; set; }
        public int Assist { get; set; }
        public int YellowCard { get; set; }
        public int RedCard { get; set; }
    }
}
