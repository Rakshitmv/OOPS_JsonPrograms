using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSJsonPrograms.UC3_StockManagement
{
    public class StockAccountManagement
    {
        public void ReadData(String filePath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    var json = reader.ReadToEnd();
                    var itemsPresent = JsonConvert.DeserializeObject<List<StocksInventory>>(json);
                    Console.WriteLine("Name\t" + "Price\t" + "NoOfShares\t" + "Total amount");
                    int totalValue = 0, amount = 0;
                    foreach (var data in itemsPresent)
                    {
                        amount = data.SharePrice * data.NumberOfShares;
                        totalValue += amount;
                        Console.WriteLine(data.StockName + "\t" + data.SharePrice + "\t" + data.NumberOfShares + "\t" + amount);
                    }
                    Console.WriteLine("\nTotal stock report" + totalValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
