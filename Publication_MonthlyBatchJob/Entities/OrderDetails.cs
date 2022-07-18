using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publication_MonthlyBatchJob.Entities
{
    public class OrderDetails
    {
        public int OrderID { get; set; }
        public int MagzineID { get; set; }
        public int Quantity { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
