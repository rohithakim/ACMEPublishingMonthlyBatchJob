using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Publication_MonthlyBatchJob.Entities;
using Publication_MonthlyBatchJob.Utilites;

namespace Publication_MonthlyBatchJob
{
    public class ProcessSubscriptions
    {

        public List<Subscription> subcriptions = new List<Subscription>();
        public List<Magzine> Magzines = new List<Magzine>();
        public List<Company> PrintCompanies = new List<Company>();

        public void addSubscription(Customer customer, Magzine mag, int subscriptionDurationinMonths, int quantity)
        {
            var subscription = new Subscription();
            subscription.Customer = customer;

            var order = new Order();
             
            order.Customer_ID = customer.ID;
            order.CompanyID = PrintCompanies.Find(x => x.Zipcode == customer.ZipCode).ID;
            order.Order_StartDate = DateTime.Now.Date;
            order.Order_EndDate = DateTime.Now.AddMonths(subscriptionDurationinMonths);
            order.Status = "A";

            int orderID = 1;
            int PaymentID = 1;
            if(subcriptions.Count >0)
            {
                orderID = (subcriptions.SelectMany(x => x.Orders)).Max(x => x.ID) + 1;
                PaymentID = (subcriptions.Select(x=> x.Paymentdetails)).Max(x=> x.ID) +1;
            }
            order.ID = orderID;

            var subscriptionPayment = new Payment(PaymentID, mag.Price,DateTime.Now.Date);
            subscription.Paymentdetails = subscriptionPayment;

            subscription.Customer = customer;
            subscription.Orders.Add(order);

            var orderDetails = new OrderDetails();

            orderDetails.MagzineID = mag.ID;
            orderDetails.OrderID = orderID;
            orderDetails.OrderDate = DateTime.Now.Date;
            orderDetails.Quantity = quantity;

            subscription.OrderDetails.Add(orderDetails);

            subcriptions.Add(subscription);


        }

        public List<Order> getActiveSubsciptions()
        {
            List<Order> activeOrders = (subcriptions.SelectMany(x => x.Orders).ToList()).FindAll(x=> x.Status == "A");

            return activeOrders;
        }

        public void sendMagzinesToCustomers(Order order)
        {
            Customer cust = subcriptions.Select(x => x.Customer).First(x => x.ID == order.Customer_ID);
            OrderDetails orderDet = (subcriptions.SelectMany(x => x.OrderDetails).ToList()).Find(x => x.OrderID == order.ID);
            Magzine mag = Magzines.Find(x => x.ID == orderDet.MagzineID);
            Company company = PrintCompanies.Find(x => x.ID == order.CompanyID);

            CallWebApi webApi = new CallWebApi();
            webApi.submitOrder(company.WebApiUrl, cust, mag);
        }
    }
}
