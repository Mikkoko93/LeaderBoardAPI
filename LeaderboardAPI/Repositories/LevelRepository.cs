using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaderboardAPI.Models;
using LeaderboardAPI.Database;

namespace LeaderboardAPI.Repositories
{
    public class LevelRepository : ILevelRepository
    {
        private readonly LeaderAPIDbContext _LeaderAPIDbContext;

        public LevelRepository(LeaderAPIDbContext leaderAPIDbContext)
        {
            _LeaderAPIDbContext = leaderAPIDbContext;
        }

        public Level GetLevel(int id) =>
            _LeaderAPIDbContext.Levels.FirstOrDefault(c => c.Id == id);

        public IEnumerable<Level> GetLevels() =>
            _LeaderAPIDbContext.Levels.ToList();

        public void AddLevel(Level level)
        {
            _LeaderAPIDbContext.Levels.Add(level);
            _LeaderAPIDbContext.SaveChanges();
        }

    }
}
