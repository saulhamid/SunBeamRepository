using FXTF.CRM.Model.Model.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FXTF.CRM.Service.Admin.Interfaces
{
    public interface IProductsBL
    {
Task<string> InsertProducts(Products entity);
Task<string> UpdateProducts(Products entity);
Task<string> DeleteProducts(Products entity);
Task<IEnumerable<Products>> GetAllProducts();
Task<Products> GetProductsById(int Id)
    }
}
