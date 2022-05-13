using ex_odata.Entities;
using System.Collections.Generic;
using System.Linq;

namespace ex_odata.Services
{
    public class CustomerService
    {
        public List<Customer> CreateMockData()
        {
            List<Customer> customerList = new(); // C# 9 Syntax

            return customerList;
        }

        public List<Customer> GetCustomers() => CreateMockData().ToList();
    }
}
