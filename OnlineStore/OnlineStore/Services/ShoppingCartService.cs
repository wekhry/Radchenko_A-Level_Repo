using OnlineStore.Entities;

namespace OnlineStore.Services
{
    internal class ShoppingCartService
    {
        private ShoppingCartEntity shoppingCart;
        public ShoppingCartService()
        {
            shoppingCart = new ShoppingCartEntity();
            shoppingCart.Items = new List<ProductEntity>();
        }

        public void AddToCart(ProductEntity product)
        {
            if(shoppingCart.Items.Count < 10)
            {
                shoppingCart.Items.Add(product);
                Console.WriteLine("Product added to the shopping cart.");
            }
            else
            {
                Console.WriteLine("Shopping cart is full. Cannot add more items.");
            }
        }

        public int PlaceOrder()
        {
            if (shoppingCart.Items.Count > 0)
            {
                int orderNumber = GenerateOrderNumber();

                OrderEntity order = new OrderEntity
                {
                    OrderNumber = orderNumber,
                    ShoppingCart = shoppingCart
                };

                shoppingCart.Items.Clear();

                Console.WriteLine($"Order with number {orderNumber} has been placed.");
                return orderNumber;
            }
            else
            {
                Console.WriteLine("Shopping cart is empty. Cannot place an order.");
                return -1;
            }
        }

        private int GenerateOrderNumber()
        {
            Random random = new Random();
            return random.Next(1000, 9999);
        }
    }

}
