using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SunBeam.Common.Log;
using SunBeam.Service.Admin.Interfaces;
using SunBeam.Data.Repositories.Implementations;
using SunBeam.Domain;

namespace SunBeam.Service.Interfaces
{


public class ProductsBL : IProductsBL
{

protected ILogger Logger { get; set; }

public ProductsBL(ILogger logger)
{
Logger = logger;
}

/// <summary>
/// Insert Products
/// </summary>
/// <param name="entity"></param>
/// <returns>Message</returns>
public async Task<string> Insert(Products entity)
{
try
{
var result = await new ProductsRepository(logger).Insert(entity);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Update Products
/// </summary>
/// <param name="entity"></param>
/// <returns>Message</returns>
public async Task<string> Update(Products entity)
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
/// Delete Products
/// </summary>
/// <param name="Id"></param>
/// <returns>Message</returns>
public async Task<string> Delete(int Id)
{
try
{
var result = await new ProductsRepository(logger).Delete(Id);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Get All Products
/// </summary>
/// <returns>List ofProducts</returns>
public async Task<IEnumerable<Products>> GetAll()
{
try
{
var result = await new ProductsRepository(logger).GetAll();
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Get Products by Id
/// </summary>
/// <param name="Id"></param>
/// <returns>Products Object</returns>
public async Task<Products> GetProductsById(int Id)
{
try
{
var result = await new ProductsRepository(logger).GetProductsById(Id);
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
