using Catalog.Host.Models.Dtos;
using Catalog.Host.Models.Response;

namespace Catalog.Host.Services.Interfaces;

public interface ICatalogService
{
    Task<PaginatedItemsResponse<CatalogItemDto>> GetCatalogItemsAsync(int pageSize, int pageIndex);
    Task<CatalogItemDto> GetCatalogItemByIdAsync(int id);
    Task<List<CatalogItemDto>> GetCatalogItemsByBrandAsync(string brand);
    Task<List<CatalogItemDto>> GetCatalogItemsByTypeAsync(string type);
    Task<List<string>> GetDistinctBrandsAsync();
    Task<List<string>> GetDistinctTypesAsync();
}