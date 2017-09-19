using SunBeam.Domain.Models;
using SunBeam.Service.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SunBeam.Web.Controllers
{
    public class ProductController : Controller
    {
        private ICustomersBL repo { get; set; }
        public ProductController(ICustomersBL repo) {
            this.repo = repo;
        }
        public async Task<IEnumerable<dynamic>> Index() {

            var data = await repo.GetAll();
            return data;
        }
    }
}
