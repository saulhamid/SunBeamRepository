using SunBeam.Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SunBeam.Service.Interfaces
{
    public interface ICustomersBL
    {
        Task<string> Insert(Customers entity);
        Task<string> Update(Customers entity);
        Task<string> Delete(Customers entity);
        Task<IEnumerable<Customers>> GetAll();
        Task<Customers> GetById(int Id);
    }
}



