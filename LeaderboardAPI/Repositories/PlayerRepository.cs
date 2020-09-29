using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaderboardAPI.Database;
using LeaderboardAPI.Models;

namespace LeaderboardAPI.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private readonly LeaderAPIDbContext _LeaderAPIDbContext;

        public PlayerRepository(LeaderAPIDbContext leaderAPIDbContext)
        {
            _LeaderAPIDbContext = leaderAPIDbContext;
        }

        /*public IEnumerable<Player> GetPlayers() =>
            _leaderAPIDbContext.Players.ToList();*/

        public Player GetPlayer(int id) =>
            _LeaderAPIDbContext.Players.FirstOrDefault(c => c.Id == id);

        public IEnumerable<Player> GetPlayers() =>
            _LeaderAPIDbContext.Players.ToList();

        public void AddPlayer(Player player)
        {
            _LeaderAPIDbContext.Players.Add(player);
            _LeaderAPIDbContext.SaveChanges();
        }
    }
}
