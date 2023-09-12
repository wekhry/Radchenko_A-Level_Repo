using OnlineStore.Entities;

namespace OnlineStore.Services
{
    internal class ProductService
    {
        private List<ProductEntity> products;
        public ProductService() 
        {
            products = new List<ProductEntity>
            {
                new ProductEntity {Id = 1, Name = "Product 1", Price = 10.99m},
                new ProductEntity {Id = 2, Name = "Product 2", Price = 15.00m},
                new ProductEntity {Id = 3, Name = "Product 3", Price = 19.99m},
                new ProductEntity {Id = 4, Name = "Product 4", Price = 19.50m},
                new ProductEntity {Id = 5, Name = "Product 5", Price = 20.00m},
                new ProductEntity {Id = 6, Name = "Product 6", Price = 21.50m},
                new ProductEntity {Id = 7, Name = "Product 7", Price = 34.80m},
                new ProductEntity {Id = 8, Name = "Product 8", Price = 69.99m},
                new ProductEntity {Id = 9, Name = "Product 9", Price = 14.99m},
                new ProductEntity {Id = 10, Name = "Product 10", Price = 20.99m},
                new ProductEntity {Id = 11, Name = "Product 11", Price = 9.99m},
                new ProductEntity {Id = 12, Name = "Product 12", Price = 45.00m},
                new ProductEntity {Id = 13, Name = "Product 13", Price = 54.99m},
                new ProductEntity {Id = 14, Name = "Product 14", Price = 36.00m},
                new ProductEntity {Id = 15, Name = "Product 15", Price = 89.99m}
            };
        }

        public List<ProductEntity> GetProducts()
        {
            return products;
        }

    }
}
