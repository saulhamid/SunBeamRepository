using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SunBeam.Common.Log;
using SunBeam.Service.Admin.Interfaces;
using SunBeam.Data.Repositories.Implementations;
using SunBeam.Domain;

namespace SunBeam.Service.Interfaces
{


public class ProductCategorysBL : IProductCategorysBL
{

protected ILogger Logger { get; set; }

public ProductCategorysBL(ILogger logger)
{
Logger = logger;
}

/// <summary>
/// Insert ProductCategorys
/// </summary>
/// <param name="entity"></param>
/// <returns>Message</returns>
public async Task<string> Insert(ProductCategorys entity)
{
try
{
var result = await new ProductCategorysRepository(logger).Insert(entity);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Update ProductCategorys
/// </summary>
/// <param name="entity"></param>
/// <returns>Message</returns>
public async Task<string> Update(ProductCategorys entity)
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
/// Delete ProductCategorys
/// </summary>
/// <param name="Id"></param>
/// <returns>Message</returns>
public async Task<string> Delete(int Id)
{
try
{
var result = await new ProductCategorysRepository(logger).Delete(Id);
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Get All ProductCategorys
/// </summary>
/// <returns>List ofProductCategorys</returns>
public async Task<IEnumerable<ProductCategorys>> GetAll()
{
try
{
var result = await new ProductCategorysRepository(logger).GetAll();
return result;
}
catch (Exception ex)
{
Logger.Error(ex.Message);
throw ex;
}
}

/// <summary>
/// Get ProductCategorys by Id
/// </summary>
/// <param name="Id"></param>
/// <returns>ProductCategorys Object</returns>
public async Task<ProductCategorys> GetProductCategorysById(int Id)
{
try
{
var result = await new ProductCategorysRepository(logger).GetProductCategorysById(Id);
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
