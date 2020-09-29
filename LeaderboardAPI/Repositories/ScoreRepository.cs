using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LeaderboardAPI.Models;
using LeaderboardAPI.Database;

namespace LeaderboardAPI.Repositories
{
    public class ScoreRepository : IScoreRepository
    {

        private readonly LeaderAPIDbContext _LeaderAPIDbContext;

        public ScoreRepository(LeaderAPIDbContext leaderAPIDbContext)
        {
            _LeaderAPIDbContext = leaderAPIDbContext;
        }

        public Score GetScore(int id) =>
            _LeaderAPIDbContext.Scores.FirstOrDefault(c => c.ScoreId == id);

        public IEnumerable<Score> GetScores() =>
            _LeaderAPIDbContext.Scores.ToList();

        public void AddScore(Score score)
        {
            _LeaderAPIDbContext.Scores.Add(score);
            _LeaderAPIDbContext.SaveChanges();
        }

        public void DeleteScore(int id)
        {
            _LeaderAPIDbContext.Remove(GetScore(id));
            _LeaderAPIDbContext.SaveChanges();
        }
    }
}
