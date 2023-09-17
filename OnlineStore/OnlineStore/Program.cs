using OnlineStore.Entities;
using OnlineStore.Services;

namespace OnlineStore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductService productService = new ProductService();
            ShoppingCartService shoppingCartService = new ShoppingCartService();
            OrderService orderService = new OrderService();

            List<ProductEntity> products = productService.GetProducts();

            for (int i = 0; i < 10; i++)
            {
                ProductEntity product = products[i];

                shoppingCartService.AddToCart(product);
            }

            int orderNumber = shoppingCartService.PlaceOrder();

            orderService.NotifyBuyer(orderNumber);

        }
    }
}