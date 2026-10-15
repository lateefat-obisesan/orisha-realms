using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms
{
   public class World
    {
        private static World _instance;

        public string GameDifficulty { get; set; }
        public int WorldTime { get; set; }
        public bool IsRunning { get; set; }

        private World()
        {
            GameDifficulty = "Normal";
            WorldTime = 1;
            IsRunning = true;
        }
    }
}
