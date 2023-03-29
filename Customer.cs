using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Service_GSM
{
    public class Customer
    {
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string BillingDetails { get; set; }
     public Customer(string name, string contactInfo, string billingDetails)
        {
            Name = name;
            ContactInfo = contactInfo;
            BillingDetails = billingDetails;
        }
        public string GetNameCustomer()
        {
            return Name;
        }
        public string GetContactInfo()
        {
            return ContactInfo;
        }
          public string GetBillingDetails()
        {
            return BillingDetails;
        }
    }
}
