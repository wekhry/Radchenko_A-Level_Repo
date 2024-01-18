using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[ApiController]
[Route(ComponentDefaults.DefaultRoute)]
public class CatalogTypeController : ControllerBase
{
    private readonly ILogger<CatalogTypeController> _logger;

    public CatalogTypeController(ILogger<CatalogTypeController> logger)
    {
        _logger = logger;
    }

    [HttpPost]
    public IActionResult AddType([FromBody] string typeName)
    {
        _logger.LogInformation("Adding new type: " + typeName);
        return Ok("Type added successfully");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteType(int id)
    {
        _logger.LogInformation("Deleting type with ID: " + id);
        return Ok("Type deleted successfully");
    }

    [HttpPut("{id}")]
    public IActionResult UpdateType(int id, [FromBody] string updatedTypeName)
    {
        _logger.LogInformation("Updating type with ID: " + id + " to " + updatedTypeName);
        return Ok("Type updated successfully");
    }
}