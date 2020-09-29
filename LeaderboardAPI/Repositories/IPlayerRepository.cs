using LeaderboardAPI.Models;
using System.Collections.Generic;

namespace LeaderboardAPI.Repositories
{
    public interface IPlayerRepository
    {
        void AddPlayer(Player player);
        Player GetPlayer(int id);
        IEnumerable<Player> GetPlayers();
    }
}