using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSJsonPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("\nEnter 1: Inventory Management\n" + "Enter 2: Inventory  Management Extended\n" +  "Enter 3: Stock Account Management\n" + "Enter 4: Exit\n");
                Console.WriteLine("Enter the option:");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:

                        InventoryManagement inventoryManagement = new InventoryManagement();
                        inventoryManagement.ReadData(@"E:\Git Programs\OOPS_JsonPrograms\OOPS_JsonPrograms\OOPSJsonPrograms\InventoryData.json");
                        break;
                    case 2:
                        InventoryManagement inventoryManagement1 = new InventoryManagement();
                        inventoryManagement1.ReadData(@"E:\Git Programs\OOPS_JsonPrograms\OOPS_JsonPrograms\OOPSJsonPrograms\InventoryData.json");
                        inventoryManagement1.Display();
                        inventoryManagement1.WriteData(@"E:\Git Programs\OOPS_JsonPrograms\OOPS_JsonPrograms\OOPSJsonPrograms\InventoryData.json");
                        break;
                    case 3:
                        UC3_StockManagement.StockAccountManagement stockAccountManagement = new UC3_StockManagement.StockAccountManagement();
                        stockAccountManagement.ReadData(@"E:\Git Programs\OOPS_JsonPrograms\OOPS_JsonPrograms\OOPSJsonPrograms\UC3_StockManagement\Stocks.json");
                        break;
                       

                }
            }
        }
    }
}
