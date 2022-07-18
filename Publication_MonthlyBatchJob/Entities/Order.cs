using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publication_MonthlyBatchJob.Entities
{
    public class Order
    {
        public int ID { get; set; }
        public int Customer_ID { get; set; }    
        public int CompanyID { get; set; }
        public string Status { get; set; }
        public DateTime Order_StartDate { get; set; }
        public DateTime Order_EndDate { get; set; }
        public string Payment_ID { get; set; }

    }
}
