using Catalog.Host.Data;
using Catalog.Host.Data.Entities;

namespace Catalog.Host.Repositories.Interfaces;

public interface ICatalogItemRepository
{
    Task<PaginatedItems<CatalogItem>> GetByPageAsync(int pageIndex, int pageSize);
    Task<int?> Add(string name, string description, decimal price, int availableStock, int catalogBrandId, int catalogTypeId, string pictureFileName);
    Task<CatalogItem> GetByIdAsync(int id);
    Task<List<CatalogItem>> GetByBrandAsync(string brand);
    Task<List<CatalogItem>> GetByTypeAsync(string type);
    Task<List<string>> GetDistinctBrandsAsync();
    Task<List<string>> GetDistinctTypesAsync();
}