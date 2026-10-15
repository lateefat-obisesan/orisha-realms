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

        public static World GetInstance()
        {
            if (_instance == null)
            {
                _instance = new World();
            }
            return _instance;
        }

        public void DisplayWorldStatus()
        {
            Console.WriteLine($"\n--- Global World State ---");
            Console.WriteLine($"Difficulty: {GameDifficulty}");
            Console.WriteLine($"World Time (Day): {WorldTime}");
        }
    }
}
