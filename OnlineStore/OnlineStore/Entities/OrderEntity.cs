namespace OnlineStore.Entities
{
    internal class OrderEntity
    {
        public int OrderNumber { get; set; }
        public ShoppingCartEntity ShoppingCart { get; set; }
    }
}
