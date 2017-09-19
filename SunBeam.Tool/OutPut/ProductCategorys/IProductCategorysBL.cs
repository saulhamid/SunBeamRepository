using FXTF.CRM.Model.Model.Admin;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FXTF.CRM.Service.Admin.Interfaces
{
    public interface IProductCategorysBL
    {
Task<string> InsertProductCategorys(ProductCategorys entity);
Task<string> UpdateProductCategorys(ProductCategorys entity);
Task<string> DeleteProductCategorys(ProductCategorys entity);
Task<IEnumerable<ProductCategorys>> GetAllProductCategorys();
Task<ProductCategorys> GetProductCategorysById(int Id)
    }
}
