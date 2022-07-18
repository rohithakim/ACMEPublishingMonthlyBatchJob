using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Publication_MonthlyBatchJob.Entities
{
    public class Customer
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string Lastname { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseAddress { get; set; }
        public string ZipCode { get; set; }

        public Customer(int id,string fName, string lName, string phNo,string email,string state,string city, string street, string zip)
        {
            ID = id;
            FirstName = fName;
            Lastname = lName;
            PhoneNumber = phNo;
            Email = email;
            State = state;
            City = city;
            Street = street;
            ZipCode = zip;
        }
    }
}
