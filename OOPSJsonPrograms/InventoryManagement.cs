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
        public void ReadData(string filepath)
        {
            try
            {
                using (StreamReader reader = new StreamReader(filepath))
                {
                    var json = reader.ReadToEnd();
                    var items = JsonConvert.DeserializeObject<List<Inventory>>(json);
                    Console.WriteLine("name\t" + "price\t" + "weight\t" + "total amount");
                    foreach (var data in items)
                    {
                        Console.WriteLine(data.Name + "\t" + data.Price + "\t" + data.Weight + "\t" + data.Price * data.Weight);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }

}
