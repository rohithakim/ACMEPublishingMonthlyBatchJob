using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publication_MonthlyBatchJob.Entities
{
    public class Subscription
    {
        public Customer Customer { get; set; }
        public List<Order> Orders = new List<Order>();
        public List<OrderDetails> OrderDetails = new List<OrderDetails>();
        public Payment Paymentdetails { get; set; }

    }
}
