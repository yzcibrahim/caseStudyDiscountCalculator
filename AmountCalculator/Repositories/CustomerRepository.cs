using AmountCalculator.Abstract;
using AmountCalculator.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AmountCalculator.Repositories
{
    public class CustomerRepository: IRepositoryCustomer
    {
        public static List<CustomerBase> customers;
        public CustomerRepository()
        {
            customers = new List<CustomerBase>();
            customers.Add(new Employee() { Id = 1, Name = "Employee1" });
            customers.Add(new Customer() { Id = 2, Name = "Customer1", CustStartDate = DateTime.Now.AddYears(-3), IsAffiliate = true });
            customers.Add(new CustomerAffiliate() { Id = 3, Name = "Customer2" });
            customers.Add(new Customer() { Id = 3, Name = "Customer3", CustStartDate = DateTime.Now.AddYears(-1), IsAffiliate = false });
        }

        public CustomerBase Get(int id)
        {
            return customers.FirstOrDefault(c => c.Id == id);
        }
    }
}
