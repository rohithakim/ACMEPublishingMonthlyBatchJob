using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publication_MonthlyBatchJob.Entities
{
    public class Payment
    {
        public int ID { get; set; }
        public long Amount { get; set; }
        public DateTime PaymentDate { get; set; }

        public Payment(int id, long amount, DateTime dt )
        {
            ID = id;
            Amount = amount;
            PaymentDate = dt;
        }
    }
}
