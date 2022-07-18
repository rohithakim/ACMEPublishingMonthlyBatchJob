using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using Publication_MonthlyBatchJob.Entities;

namespace Publication_MonthlyBatchJob.Utilites
{
    public class CallWebApi
    {
 
        public void submitOrder(string webUrl, Customer cust, Magzine mag)
        {
            using (var client = new HttpClient())
            {
                //client.BaseAddress = new Uri(webUrl);
                //client.DefaultRequestHeaders.Accept.Clear();
                //client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                ////GET Method
                //HttpResponseMessage response = await client.GetAsync("api/SubGenerateOrder/customer");
                //if (response.IsSuccessStatusCode)
                //{
                   
                //}
                //else
                //{
                //    Console.WriteLine("Internal server Error");
                //}
            }
        }
    }
}
