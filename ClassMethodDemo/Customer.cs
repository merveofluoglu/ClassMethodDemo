using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class Customer
    {
        public string CustomerName { get; set; }
        public int CustomerId { get; set; }
        public double CustomerMoney { get; set; }
        public int CustomerPhone { get; set; }
        public CustomerManager CustomerManager { get; set; }
        public string CustomerBankAccount { get; set; }
        public void DisplayCustomerInfo()
        {
            Console.WriteLine("Customer Name: " + this.CustomerName);
            Console.WriteLine("Customer Id: " + this.CustomerId);
            Console.WriteLine("Customer phone number: " + this.CustomerPhone);
            Console.WriteLine("Customer's Bank Account Number: " + this.CustomerBankAccount);
            Console.WriteLine("The money on the account: " + this.CustomerMoney);
            Console.WriteLine("Customer's Manager Info: " + this.CustomerManager.ManagerName);
        }
    }
}
