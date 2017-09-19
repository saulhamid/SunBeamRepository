using SunBeam.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SunBeam.Data.Repositories.Interfaces
{
    interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetByID(long ID);
        Task<string> Insert(T Entity);
        Task<string> Delete(long ID);
        Task<string> Update(T Entity);
        T Mapping(SqlDataReader sqldatareader);
    }
}
