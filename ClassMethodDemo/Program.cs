using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager Manager1 = new CustomerManager();
            Manager1.ManagerName = "CUSTOMER MANAGER";

            Customer customer1 = new Customer
            {
                CustomerName = "Merve Ofluoglu",
                CustomerId = 123456789,
                CustomerMoney = 1000,
                CustomerPhone = 0500000000,
                CustomerManager = Manager1,
                CustomerBankAccount = "TR 05505455 54435 454"
            };
            Customer customer2 = new Customer
            {
                CustomerName = "Elif Ofluoglu",
                CustomerId = 098764321,
                CustomerMoney = 5000,
                CustomerPhone = 0500011111,
                CustomerManager = Manager1,
                CustomerBankAccount = "TR 05505455 65498 782"
            };

            Manager1.AddCustomer(customer1);
            Manager1.AddCustomer(customer2);
            Manager1.ListAllCustomers();

            Console.WriteLine("*******************************");

            Manager1.AddMoney(ref customer1, 2000); // Adding 2000$ to do customer1
            Manager1.TransferMoney(ref customer2, 3000); // Transferring 3000$ from customer2
            Manager1.ListAllCustomers();

            Console.WriteLine("*******************************");

            Manager1.DeleteCustomer(customer2);
            Manager1.ListAllCustomers();

        }
    }
}
