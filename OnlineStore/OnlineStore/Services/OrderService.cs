namespace OnlineStore.Services
{
    internal class OrderService
    {
        public void NotifyBuyer(int orderNumber)
        {
            Console.WriteLine($"Buyer notified about order with number {orderNumber}.");
        }
    }
}
