using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine("Customer added :" + customer.Name);
        }

        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine("Customer deleted :" + customer.Name);
        }

        public void ListCustomers(params Customer[] customers)
        {
            
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Customers :" + customer.Name + "-- " + customer.Surname + "-- " + "-- " + customer.Age);
                Console.WriteLine("-----------------------------");
            }

        }
    }
}
