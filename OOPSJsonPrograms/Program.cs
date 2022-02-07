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
            InventoryManagement inventoryManagement = new InventoryManagement();
            inventoryManagement.ReadData(@"E:\Git Programs\OOPS_JsonPrograms\OOPS_JsonPrograms\OOPSJsonPrograms\InventoryData.json");
            Console.ReadKey();

        }
    }
}
