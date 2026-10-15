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
                        Console.WriteLine("Choose Lineage (ogun - eshu - yemoja): ");
                        string type = Console.ReadLine();
                        playerCharacter = Factory.CreateCharacter(type, name);
                        Console.WriteLine("Character created successfully!");
                        break;

                    case "2":
                        if (playerCharacter != null) playerCharacter.PrintDetails();
                        else Console.WriteLine("No character created yet!");
                        break;

                    case "3":
                        if (playerCharacter != null)
                        {
                            Console.WriteLine("\n--- Actions ---");
                            playerCharacter.Act();
                            playerCharacter.Speak();
                        }
                        else Console.WriteLine("No character found!");
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
                        Console.WriteLine("1. Add Item - 2. View Items");
                        string invChoice = Console.ReadLine();
                        if (invChoice == "1")
                        {
                            Console.Write("Enter item name: ");
                            playerInventory.AddItem(Console.ReadLine());
                        }
                        else playerInventory.ShowItems();
                        break;
                }
            }
    }
}
