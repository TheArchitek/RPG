using rpgFighter.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpgFighter.Utilities
{
    class Storage
    {
        private int MaximumCapacity { get; set; }
        private List<Equipment> Inventory;

        public Storage(int MaximumCapacity)
        { }
           
        public void AddItem(Equipment item)
        {
            Inventory.Add(item);
        }
        public override string ToString()
        {
            string inventoryList = "";

            foreach (Equipment i in Inventory)
            {
                inventoryList += i.ToString() + Environment.NewLine;
            }

            return inventoryList;
        }
        
        /*public Equipment GetItem()
        {
            return Inventory.FirstOrDefault(x = )
        }*/
    }
}
