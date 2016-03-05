using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADO.Models;

namespace ADO
{
    public class DatabaseManager
    {
        readonly static taxisystemContext _context = new taxisystemContext();

        public static void Print()
        {
            PrintList(GetAllCustomers());
        }

        private static void PrintList(List<Customer> list)
        {
            foreach(Customer cust in list)
            {
                Console.WriteLine(cust.CustomerName);
            }
        }

        private static List<Customer> GetAllCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            customerList = _context.Customers.ToList();
            return customerList;
        }
    }
}
