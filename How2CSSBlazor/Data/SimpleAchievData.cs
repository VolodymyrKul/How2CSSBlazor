using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace How2CSSBlazor.Data
{
    public class SimpleAchievData
    {
        public string TrainingTestTitle { get; set; }
        public string CompletedCount { get; set; }
        public string CorrectCount { get; set; }
        public int CurrentMark { get; set; }
        public int TryCount { get; set; }
        public DateTime SaveDate { get; set; }
    }
}
