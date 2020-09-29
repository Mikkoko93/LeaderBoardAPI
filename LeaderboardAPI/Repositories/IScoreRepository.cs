using LeaderboardAPI.Models;
using System.Collections.Generic;

namespace LeaderboardAPI.Repositories
{
    public interface IScoreRepository
    {
        void AddScore(Score score);
        void DeleteScore(int id);
        Score GetScore(int id);
        IEnumerable<Score> GetScores();
    }
}