using CustomerPortal.WebApi.Models;
using CustomerPortal.WebApi.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerPortal.WebApi.Services
{
    public class CustomerService : ICustomerService
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Customer InsertUpdate(Customer customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> Search(string name)
        {
            throw new NotImplementedException();
        }
    }
}