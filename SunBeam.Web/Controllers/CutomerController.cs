
using SunBeam.Domain.Models;
using SunBeam.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SunBeam.Web.Controllers
{
    public class CutomerController : Controller
    {
        private readonly ICustomersBL repo;
        public CutomerController(ICustomersBL _repo)
        {
            this.repo = _repo;
        }
        [HttpGet]
        public async Task<IEnumerable<Customers>> Index()
        {
            try
            {
                var data = await repo.GetAll();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpGet]
        public async Task<Customers> GetById(int Id)
        {
            try
            {
                var data = await repo.GetById(Id);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public async Task<string> Insert(Customers cust)
        {
            try
            {
                var data = await repo.Insert(cust);
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
