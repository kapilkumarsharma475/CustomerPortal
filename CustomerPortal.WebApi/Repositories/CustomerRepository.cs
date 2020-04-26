using CustomerPortal.WebApi.Models;
using CustomerPortal.WebApi.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerPortal.WebApi.Repositories
{
    public class CustomerRepository : IRepository<Customer>
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Customer> GetAll()
        {
            throw new NotImplementedException();
        }

        public Customer GetbyId(long id)
        {
            throw new NotImplementedException();
        }

        public Customer Insert(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}