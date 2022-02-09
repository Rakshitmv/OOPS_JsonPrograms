using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSJsonPrograms
{
    public class InventoryManagement
    {
        List<Inventory> riceList = new List<Inventory>();
        List<Inventory> wheatList = new List<Inventory>();
        List<Inventory> pulsesList = new List<Inventory>();
        public void ReadData(string filepath)
        {
            using (StreamReader reader = new StreamReader(filepath))
            {
                var json = reader.ReadToEnd();
                var inventoryData = JsonConvert.DeserializeObject<InventoryFactory>(json);
                this.riceList = inventoryData.Rice;
                this.wheatList = inventoryData.Wheat;
                this.pulsesList = inventoryData.Pulses;
            }
        }
        public void Display()
        {
            if (this.riceList != null)
            {
                Console.WriteLine("RiceList");
                Console.WriteLine("Name" + "\t" + "Price" + "\t" + "Weight");

                foreach (var item in this.riceList)
                {
                    Console.WriteLine(item.Name + "\t" + item.Price + "\t" + item.Weight);
                }
            }
            if (this.wheatList != null)
            {
                Console.WriteLine("WheatList");
                Console.WriteLine("Name" + "\t" + "Price+\tWeight");

                foreach (var item in this.wheatList)
                {
                    Console.WriteLine(item.Name + "\t" + item.Price + "\t" + item.Weight);
                }
            }
            if (this.pulsesList != null)
            {
                Console.WriteLine("PulsesList");
                Console.WriteLine("Name" + "\t" + "Price" + "\t" + "Weight");

                foreach (var item in this.pulsesList)
                {
                    Console.WriteLine(item.Name + "\t\t" + item.Price + "\t\t" + item.Weight);
                }
            }
        }
        public bool IsDuplicate(List<Inventory> inventory, string name)
        {
            foreach (var data in inventory)
            {
                if (data.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        public void WriteData(string filePath)
        {
            try
            {
                Console.WriteLine("\n" + "Enter the option: Enter" + "\n" + "1: For Rice " + "\n" + "2: For Wheat " + "\n" + "3: for Pulses");
                int option = Convert.ToInt32(Console.ReadLine());
                Inventory inventory = new Inventory();
                switch (option)
                {
                    case 1:
                        inventory.Name = "Blue Rice";
                        inventory.Price = 20;
                        inventory.Weight = 30;
                        if (!IsDuplicate(this.riceList, inventory.Name))
                        {
                            this.riceList.Add(inventory);
                        }
                        else
                        {
                            Console.WriteLine("The current item is already present");
                        }
                        break;

                    case 2:
                        inventory.Name = "Green Wheat";
                        inventory.Price = 20;
                        inventory.Weight = 30;
                        if (!IsDuplicate(this.wheatList, inventory.Name))
                        {
                            this.wheatList.Add(inventory);
                        }
                        else
                        {
                            Console.WriteLine("The current item is already present");
                        }
                        break;

                    case 3:
                        inventory.Name = "Peas";
                        inventory.Price = 23;
                        inventory.Weight = 35;
                        if (!IsDuplicate(this.pulsesList, inventory.Name))
                        {
                            this.pulsesList.Add(inventory);
                        }
                        else
                        {
                            Console.WriteLine("The current item is already present ");
                        }
                        break;
                }
                InventoryFactory inventoryFactory = new InventoryFactory();
                inventoryFactory.Rice = this.riceList;
                inventoryFactory.Wheat = this.wheatList;
                inventoryFactory.Pulses = this.pulsesList;

                var jsonData = JsonConvert.SerializeObject(inventoryFactory);
                File.WriteAllText(filePath, jsonData);

                ReadData(filePath);
                Display();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
