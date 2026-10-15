using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms
{
    public class Controller
    {
        public void Start()
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
                Console.WriteLine("1. Create Character");
                Console.WriteLine("2. View Details");
                Console.WriteLine("3. Act and Speak");
                Console.WriteLine("4. Add Power");
                Console.WriteLine("5. Inventory");
                Console.WriteLine("6. Advance Day");
                Console.WriteLine("7. Exit");
                Console.Write("Select an option (1-7): ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Console.Write("Enter character name: ");
                        string name = Console.ReadLine();
                        Console.WriteLine("Choose Lineage (Ogun - Esu - Yemoja): ");
                        string type = Console.ReadLine();
                        playerCharacter = Factory.CreateCharacter(type, name);
                        Console.WriteLine("Character created successfully!");
                        break;

                    case "2":
                        if (playerCharacter != null) playerCharacter.PrintDetails();
                        else Console.WriteLine("No character created yet!");
                        break;

                    case "4":
                        if (playerCharacter != null)
                        {
                            Console.WriteLine("Choose Power (1. FirePower - 2. WaterPower): ");
                            string powerChoice = Console.ReadLine();
                            if (powerChoice == "1") playerCharacter = new FirePower(playerCharacter);
                            else if (powerChoice == "2") playerCharacter = new WaterPower(playerCharacter);
                            Console.WriteLine("Specialization applied!");
                        }
                        else Console.WriteLine("Create a character first!");
                        break;

                    case "5":
                        Console.WriteLine("1. Add Item");
                        Console.WriteLine("2. View Items");
                        Console.Write("Select choice: ");
                        string inventoryOption = Console.ReadLine();
                        if (inventoryOption == "1")
                        {
                            Console.Write("Enter item name: ");
                            string newItem = Console.ReadLine();
                            playerInventory.AddItem(newItem);
                        }
                        else if (inventoryOption == "2")
                        {
                            playerInventory.ShowItems();
                        }
                        break;

                    case "6":
                        world.WorldTime++;
                        Console.WriteLine($"Current Day {world.WorldTime}");
                        break;

                    case "7":
                        world.IsRunning = false;
                        Console.WriteLine("Exiting simulation.");
                        break;

                    default:
                        Console.WriteLine("Option not available.");
                        break;
                }

                if (world.IsRunning)
                {
                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadLine();
                }
            }
        }
    }
}
