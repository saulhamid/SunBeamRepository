using FXTF.CRM.Model.Model.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FXTF.CRM.Service.Admin.Interfaces
{
    public interface ICustomersBL
    {
Task<string> InsertCustomers(Customers entity);
Task<string> UpdateCustomers(Customers entity);
Task<string> DeleteCustomers(Customers entity);
Task<IEnumerable<Customers>> GetAllCustomers();
Task<Customers> GetCustomersById(int Id)
    }
}
