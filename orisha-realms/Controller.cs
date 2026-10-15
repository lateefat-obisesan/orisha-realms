using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms
{
   public class Controller
    {
        public void RunSimulation()
        {
            World world = World.GetInstance();
            Character playerCharacter = null;
            Inventory playerInventory = new Inventory();

            while (world.IsRunning)
            {
                Console.Clear();
                Console.WriteLine("===============================");
                Console.WriteLine("      ORISHA REALMS MENU       ");
                Console.WriteLine("===============================");
                world.DisplayWorldStatus();
                Console.WriteLine("1. Create Character (Ogun, Esu, Yemoja)");
                Console.WriteLine("2. View Character Details & Stats");
                Console.WriteLine("3. Perform Action & Speak");
                Console.WriteLine("4. Add Specialization (Fire/Water Power)");
                Console.WriteLine("5. Manage Inventory (Add/View Items)");
                Console.WriteLine("6. Advance World Time (Day++)");
                Console.WriteLine("7. Exit Simulation");
                Console.Write("Select an option (1-7): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter character name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Choose Lineage (ogun / eshu / yemoja): ");
                        string type = Console.ReadLine();
                        playerCharacter = Factory.CreateCharacter(type, name);
                        Console.WriteLine("Character created successfully!");
                        break;

                    case "2":
                        if (playerCharacter != null) playerCharacter.PrintDetails();
                        else Console.WriteLine("No character created yet!");
                        break;


                }
            }
    }
}
