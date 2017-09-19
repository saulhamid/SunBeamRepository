using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SunBeam.Common.Log;
using SunBeam.Service.Admin.Interfaces;
using SunBeam.Data.Repositories.Implementations;
using SunBeam.Domain;

namespace SunBeam.Service.Interfaces
{


public class CustomersBL : ICustomersBL
{

protected ILogger Logger { get; set; }

public CustomersBL(ILogger logger)
{
Logger = logger;
}

/// <summary>
/// Insert Customers
/// </summary>
/// <param name="entity"></param>
/// <returns>Message</returns>
public async Task<string> Insert(Customers entity)
{
try
{
var result = await new CustomersRepository(logger).Insert(entity);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Update Customers
/// </summary>
/// <param name="entity"></param>
/// <returns>Message</returns>
public async Task<string> Update(Customers entity)
{
try
{
var result = await new HoliDayRepository(logger).Update(entity);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Delete Customers
/// </summary>
/// <param name="Id"></param>
/// <returns>Message</returns>
public async Task<string> Delete(int Id)
{
try
{
var result = await new CustomersRepository(logger).Delete(Id);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Get All Customers
/// </summary>
/// <returns>List ofCustomers</returns>
public async Task<IEnumerable<Customers>> GetAll()
{
try
{
var result = await new CustomersRepository(logger).GetAll();
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Get Customers by Id
/// </summary>
/// <param name="Id"></param>
/// <returns>Customers Object</returns>
public async Task<Customers> GetCustomersById(int Id)
{
try
{
var result = await new CustomersRepository(logger).GetCustomersById(Id);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}


}


}
