using LeaderboardAPI.Models;
using System.Collections.Generic;

namespace LeaderboardAPI.Repositories
{
    public interface ILevelRepository
    {
        void AddLevel(Level level);
        Level GetLevel(int id);
        IEnumerable<Level> GetLevels();
    }
}