#region Library
using SunBeam.Domain.Models;
using SunBeam.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
#endregion library
 
namespace SunBeam.Web.Areas.Config.Controllers
{
public class EmployeController:Controller
{
private readonly IEmployeeBL repo;
public EmployeController(IEmployeeBL _repo)
{
this.repo = _repo;
}
 
 public ActionResult Index()
 {
 return View();
 }
 
[HttpGet] 
public ActionResult Create()
{
return PartialView();
}
[HttpPost] 
  public async Task<ActionResult> Create(Employee data)
{ 
 string result = string.Empty; 
try 
 {
result = await repo.InsertEmployee(data); 
 }
catch (Exception ex) 
{ 
 throw;
 }
return Json(result,JsonRequestBehavior.AllowGet); 
} 
[HttpGet] 
public ActionResult Edit(int Id) 
{ 
 dynamic data; 
 try
 {
 data =  repo.GetEmployeeById(Id).Result;
 }
catch (Exception ex) 
{ 
 throw;
 }
 return PartialView(data);
}
 [HttpPost] 
  public async Task<ActionResult> Edit(Employee data)
{ 
 string result = string.Empty; 
try 
 {
result = await repo.UpdateEmployee(data); 
 }
catch (Exception ex) 
{ 
 throw;
 }
return Json(result,JsonRequestBehavior.AllowGet); 
} 
 
 public async Task<JsonResult> Delete(string ids) 
 {
string result = string.Empty; 
string[] IdList = ids.Split('~'); 
Employee vm = new Employee(); 
try 
{ 
 result = await repo.DeleteEmployee(IdList,vm); 
 }
catch (Exception ex) 
{ 
 throw;
 }
  return Json(result, JsonRequestBehavior.AllowGet);
} 
 public async Task<JsonResult> DropDownEmployee() 
 {
   dynamic result;
 try
 {
  result = await repo.DropDownEmployee();
 }
catch (Exception ex) 
 {
  throw ex;
} 
return Json(new SelectList((result), "Id","Name"), JsonRequestBehavior.AllowGet); 
 }
 
}
}
