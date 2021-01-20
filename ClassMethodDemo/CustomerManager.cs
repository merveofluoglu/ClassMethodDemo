using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public string ManagerName { get; set; }
        public List<Customer> Customers = new List<Customer>(); // This attribute has been 
                                                                // considered as one customer manager
                                                                // can manage 10 customer at most.
        public int CustomerNumber = 0;

        public void ListAllCustomers()
        {
            Console.WriteLine("Listing Customers...");
            foreach (Customer customer in Customers)
            {
                customer.DisplayCustomerInfo();
                Console.WriteLine("---------------------------");
            }
        }

        public void AddCustomer(Customer customer)
        {
            if (CustomerNumber < 10)
            {
                Customers.Add(customer);
                CustomerNumber++;
            }
            else
            {
                Console.WriteLine("You can not add any more customer " +
                    "to this customer manager. Please choose another manager.");
            }
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Deleting customer...");
            int Index = 0;
            int count = 0;
            foreach (Customer custom in Customers)
            {
                if (custom.Equals(customer))
                {
                    Index = count;
                    break;
                }
                count++;
            }
            Customers.RemoveAt(Index);
        }

        public void AddMoney(ref Customer customer, float amount)
        {
            customer.CustomerMoney += amount;
        }

        public void TransferMoney(ref Customer customer, float amount)
        {
            customer.CustomerMoney -= amount;
        }

    }
}
