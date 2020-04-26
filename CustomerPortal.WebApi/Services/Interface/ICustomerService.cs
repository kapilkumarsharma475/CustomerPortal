using CustomerPortal.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPortal.WebApi.Services.Interface
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAll();
        Customer GetById(int id);
        Customer InsertUpdate(Customer customer);
        void Delete(int id);
        IEnumerable<Customer> Search(string name);
    }
}
