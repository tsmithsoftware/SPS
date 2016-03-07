using System.Collections.Generic;
using System;
using ADO;
using ADO.Models;

namespace TestConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            /**SqlRepository<Customer> customerRepository = new SqlRepository<Customer>(
                new ObjectContext(
                    ConfigurationManager.ConnectionStrings["ServiceProviderContext"].ConnectionString));**/
            DatabaseManager _manager = new DatabaseManager(new taxisystemContext());
            List<Customer> list = _manager.GetAllCustomers();
            foreach (Customer customer in list)
            {
                Console.WriteLine(customer.CustomerID);
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.CustomerHouseNumber);
                Console.WriteLine(customer.CustomerPostcode);
            }
        }
    }
}
