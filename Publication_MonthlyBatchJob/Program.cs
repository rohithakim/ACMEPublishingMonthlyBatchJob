using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Publication_MonthlyBatchJob.Entities;
using Publication_MonthlyBatchJob.Utilites;

namespace Publication_MonthlyBatchJob
{
    class Program
    { 
        static void Main(string[] args)
        {
           
            ProcessSubscriptions subcriptions = new ProcessSubscriptions();

            #region Sample Datasetup
            var sportILLustrated = new Magzine(1,"SportIllustrated",12);
            var ReaderDigest = new Magzine(2, "ReaderDigest", 10);
            var NationalGeographic = new Magzine(3, "NationalGeographic", 15);

            subcriptions.Magzines.Add(sportILLustrated);
            subcriptions.Magzines.Add(ReaderDigest);
            subcriptions.Magzines.Add(NationalGeographic);

            var vicPublishingHouse = new Company(1, "Vic Publishing House", "VIC", "Melbourne", "3000","http://companyurl/submitOrder/Customer/Magzine/");
            var NSWPrintingPress = new Company(2, "NSW Printing Press", "NSW", "Sydney", "2000", "http://companyurl/submitOrder/Customer/Magzine/");
            var QueenslandPublishing = new Company(3, "Queensland Publishing", "QLD", "Brisbane", "4000", "http://companyurl/submitOrder/Customer/Magzine/");

            subcriptions.PrintCompanies.Add(vicPublishingHouse);
            subcriptions.PrintCompanies.Add(NSWPrintingPress);
            subcriptions.PrintCompanies.Add(QueenslandPublishing);

            var VicCustomer = new Customer(1,"Jason","Holder","01241234","abc@gmail.com","VIC","Melbourne","Hamilton","3000");
            var NSWCustomer = new Customer(2, "John", "Hann", "01241284", "xyz@gmail.com", "NSW", "Sydney", "Middleton", "2000");
            var QLDCustomer = new Customer(3, "Mary", "Spicks", "022241234", "pqr@gmaail.com", "QLD", "Brisbane", "Living CR", "4000");

            subcriptions.addSubscription(VicCustomer, sportILLustrated, 12, 1);
            subcriptions.addSubscription(NSWCustomer, ReaderDigest, 6, 1);
            subcriptions.addSubscription(QLDCustomer, NationalGeographic, 12, 1);

            #endregion

            try
            {
                List<Order> activeOrders = subcriptions.getActiveSubsciptions();

                foreach(Order order in activeOrders)
                {
                    subcriptions.sendMagzinesToCustomers(order);
                }

            }
            catch(Exception ex)
            {
                LogWriter log = new LogWriter();
                log.LogWrite("Error: "  + ex.Message);
            }

        }
    }
}
