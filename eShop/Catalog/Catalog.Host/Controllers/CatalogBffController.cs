using System.Net;
using Catalog.Host.Data.Entities;
using Catalog.Host.Models.Dtos;
using Catalog.Host.Models.Requests;
using Catalog.Host.Models.Response;
using Catalog.Host.Services.Interfaces;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Host.Controllers;

[ApiController]
[Route(ComponentDefaults.DefaultRoute)]
public class CatalogBffController : ControllerBase
{
    private readonly ILogger<CatalogBffController> _logger;
    private readonly ICatalogService _catalogService;

    public CatalogBffController(
        ILogger<CatalogBffController> logger,
        ICatalogService catalogService)
    {
        _logger = logger;
        _catalogService = catalogService;
    }

    [HttpPost]
    [ProducesResponseType(typeof(PaginatedItemsResponse<CatalogItemDto>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> Items(PaginatedItemsRequest request)
    {
        var result = await _catalogService.GetCatalogItemsAsync(request.PageSize, request.PageIndex);
        return Ok(result);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(typeof(CatalogItemDto), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> GetById(int id)
    {
        var item = await _catalogService.GetCatalogItemByIdAsync(id);
        if (item == null)
        {
            return NotFound();
        }

        return Ok(item);
    }

    [HttpGet("GetByBrand/{brand}")]
    [ProducesResponseType(typeof(List<CatalogItemDto>), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> GetByBrand(string brand)
    {
        var items = await _catalogService.GetCatalogItemsByBrandAsync(brand);
        if (items == null || !items.Any())
        {
            return NotFound();
        }

        return Ok(items);
    }

    [HttpGet("GetByType/{type}")]
    [ProducesResponseType(typeof(List<CatalogItemDto>), (int)HttpStatusCode.OK)]
    [ProducesResponseType((int)HttpStatusCode.NotFound)]
    public async Task<IActionResult> GetByType(string type)
    {
        var items = await _catalogService.GetCatalogItemsByTypeAsync(type);
        if (items == null || !items.Any())
        {
            return NotFound();
        }

        return Ok(items);
    }

    [HttpGet("GetBrands")]
    [ProducesResponseType(typeof(List<string>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetBrands()
    {
        var brands = await _catalogService.GetDistinctBrandsAsync();
        return Ok(brands);
    }

    [HttpGet("GetTypes")]
    [ProducesResponseType(typeof(List<string>), (int)HttpStatusCode.OK)]
    public async Task<IActionResult> GetTypes()
    {
        var types = await _catalogService.GetDistinctTypesAsync();
        return Ok(types);
    }
}