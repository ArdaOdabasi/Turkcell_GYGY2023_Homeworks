using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeagueApp.Entities
{
    public class Stadium : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public string Address { get; set; } = string.Empty;
        public Team? Team { get; set; }
        public int? TeamId { get; set; }
        public ICollection<Match>? Matches { get; set; }
    }
}
