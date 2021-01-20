using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Name = "Mert";
            customer1.Surname = "Sevingit";
            customer1.Age = 26;

            Customer customer2 = new Customer();
            customer2.Name = "Mert2";
            customer2.Surname = "Sevingit2";
            customer2.Age = 23;

            Customer[] customers = new Customer[] {customer1,customer2 };

            foreach (Customer customer  in customers)
            {
                Console.WriteLine("Customers :" + customer.Name +"-- "+ customer.Surname + "-- "+"-- "+ customer.Age);
                Console.WriteLine("-----------------------------");
            }

            CustomerManager customerManager = new CustomerManager();
            customerManager.ListCustomers(customer1,customer2);
            customerManager.AddCustomer(customer1);
            customerManager.DeleteCustomer(customer2);
        }
    }
}
