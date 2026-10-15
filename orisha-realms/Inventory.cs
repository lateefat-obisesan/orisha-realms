using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orisha_realms
{
   public class Inventory
    {
        private List<string> _items = new List<string>();
        public void AddItem(string item)
        {
            _items.Add(item);
            Console.WriteLine($"[Game items] Added item: {item}");
        }

        public void ShowItems()
        {
            Console.WriteLine("\n--- Inventory Items ---");
            if (_items.Count == 0)
            {
                Console.WriteLine("Inventory is empty.");
            }
        }
}
