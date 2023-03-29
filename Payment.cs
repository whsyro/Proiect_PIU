using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service_GSM
{
    internal class Payment
    {
        public Customer Customer { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string PaymentMethod { get; set; }
        public Payment(Customer customer, decimal amount, DateTime date, string paymentMethod)
        {
            Customer = customer;
            Amount = amount;
            Date = date;
            PaymentMethod = paymentMethod;
        }
        public string GetCustomerName()
        {
            return CustomerName;
        }
        public decimal GetAmount()
        {
            return Amount;
        }
        public DateTime GetDate()
        {
            return Date;
        }
        public string GetPaymentMethod()
        {
            return PaymentMethod;
        }
    }
}
