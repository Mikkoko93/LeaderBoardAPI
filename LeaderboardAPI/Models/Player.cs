using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace LeaderboardAPI.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CountryCode { get; set; }

        //public virtual ICollection<Score> Scores { get; set; }

        public Player() { }

        public Player(
            int id = 0,
            string name = "Unknown",
            int countryCode = 0
            )
        {
            Id = id;
            Name = name;
            CountryCode = countryCode;
        }

        public Player(Player other)
        {
            Id = other.Id;
            Name = other.Name;
            CountryCode = other.CountryCode;
        }
    }
}
