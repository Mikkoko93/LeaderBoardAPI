using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaderboardAPI.Models
{
    public class Score
    {
        public int ScoreId { get; set; }
        public DateTime ScoreDateTime { get; }
        public int TimeinSeconds { get; set; }
        public int HighScore { get; set; }
        public int PlayerId { get; set; }
        public int LevelId { get; set; }

        //public virtual Player Player { get; set; }
        //public virtual Level Level { get; set; }

        public Score() { }

        
    }
}
