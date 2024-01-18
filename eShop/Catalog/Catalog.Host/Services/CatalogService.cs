using AutoMapper;
using Catalog.Host.Configurations;
using Catalog.Host.Data;
using Catalog.Host.Models.Dtos;
using Catalog.Host.Models.Response;
using Catalog.Host.Repositories.Interfaces;
using Catalog.Host.Services.Interfaces;

namespace Catalog.Host.Services;

public class CatalogService : BaseDataService<ApplicationDbContext>, ICatalogService
{
    private readonly ICatalogItemRepository _catalogItemRepository;
    private readonly IMapper _mapper;

    public CatalogService(
        IDbContextWrapper<ApplicationDbContext> dbContextWrapper,
        ILogger<BaseDataService<ApplicationDbContext>> logger,
        ICatalogItemRepository catalogItemRepository,
        IMapper mapper)
        : base(dbContextWrapper, logger)
    {
        _catalogItemRepository = catalogItemRepository;
        _mapper = mapper;
    }

    public async Task<PaginatedItemsResponse<CatalogItemDto>> GetCatalogItemsAsync(int pageSize, int pageIndex)
    {
        return await ExecuteSafeAsync(async () =>
        {
            var result = await _catalogItemRepository.GetByPageAsync(pageIndex, pageSize);
            return new PaginatedItemsResponse<CatalogItemDto>()
            {
                Count = result.TotalCount,
                Data = result.Data.Select(s => _mapper.Map<CatalogItemDto>(s)).ToList(),
                PageIndex = pageIndex,
                PageSize = pageSize
            };
        });
    }

    public async Task<CatalogItemDto> GetCatalogItemByIdAsync(int id)
    {
        return await ExecuteSafeAsync(async () =>
        {
            var catalogItem = await _catalogItemRepository.GetByIdAsync(id);
            if (catalogItem == null)
            {
                throw new Exception("Catalog item with ID " + id + " was not found.");
            }

            return _mapper.Map<CatalogItemDto>(catalogItem);
        });
    }

    public async Task<List<CatalogItemDto>> GetCatalogItemsByBrandAsync(string brand)
    {
        return await ExecuteSafeAsync(async () =>
        {
            var items = await _catalogItemRepository.GetByBrandAsync(brand);
            return items.Select(item => _mapper.Map<CatalogItemDto>(item)).ToList();
        });
    }

    public async Task<List<CatalogItemDto>> GetCatalogItemsByTypeAsync(string type)
    {
        return await ExecuteSafeAsync(async () =>
        {
            var items = await _catalogItemRepository.GetByTypeAsync(type);
            return items.Select(item => _mapper.Map<CatalogItemDto>(item)).ToList();
        });
    }

    public async Task<List<string>> GetDistinctBrandsAsync()
    {
        return await ExecuteSafeAsync(async () =>
        {
            var distinctBrands = await _catalogItemRepository.GetDistinctBrandsAsync();
            return distinctBrands.ToList();
        });
    }

    public async Task<List<string>> GetDistinctTypesAsync()
    {
        return await ExecuteSafeAsync(async () =>
        {
            var distinctTypes = await _catalogItemRepository.GetDistinctTypesAsync();
            return distinctTypes.ToList();
        });
    }
}