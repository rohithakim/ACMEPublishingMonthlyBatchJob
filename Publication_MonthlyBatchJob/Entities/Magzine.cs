using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publication_MonthlyBatchJob.Entities
{
    public class Magzine
    {
        public int ID { get; set; }
        public string Name { get; set; } 
        public long Price { get; set; }

        public Magzine(int id, string name, long price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }
}
