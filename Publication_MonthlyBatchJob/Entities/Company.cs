using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publication_MonthlyBatchJob.Entities
{
    public class Company
    {
        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public string WebApiUrl { get; set; }

        public Company(int id, string name,string state, string city, string zipcd,string apiUri)
        {
            ID = id;
            CompanyName = name;
            State = state;
            City = city;
            Zipcode = zipcd;
            WebApiUrl = apiUri;
        }
    }
}
