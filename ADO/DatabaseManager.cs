using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOv2.Models;

namespace ADO
{
    public class DatabaseManager
    {
        private static taxisystemContext _context;
        public DatabaseManager(taxisystemContext context)
        {
            _context = context;
        }

        public void Print()
        {
            PrintList(GetAllCustomers());
        }

        private void PrintList(List<Customer> list)
        {
            foreach(Customer cust in list)
            {
                Console.WriteLine(cust.CustomerName);
            }
        }

        public List<Customer> GetAllCustomers()
        {
            List<Customer> customerList = new List<Customer>();
            customerList = _context.Customers.ToList();
            return customerList;
        }
    }
}
