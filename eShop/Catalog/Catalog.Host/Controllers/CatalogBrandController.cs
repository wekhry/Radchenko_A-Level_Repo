using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[ApiController]
[Route(ComponentDefaults.DefaultRoute)]
public class CatalogBrandController : ControllerBase
{
    private readonly ILogger<CatalogBrandController> _logger;

    public CatalogBrandController(ILogger<CatalogBrandController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult AddBrand([FromBody] string brandName)
    {
        _logger.LogInformation("Adding new brand: " + brandName);
        return Ok("Brand added successfully");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteBrand(int id)
    {
        _logger.LogInformation("Deleting brand with ID: " + id);
        return Ok("Brand deleted successfully");
    }

    [HttpPut("{id}")]
    public IActionResult UpdateBrand(int id, [FromBody] string updatedBrandName)
    {
        _logger.LogInformation("Updating brand with ID: " + id + " to " + updatedBrandName);
        return Ok("Brand updated successfully");
    }
}