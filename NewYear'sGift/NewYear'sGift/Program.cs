namespace NewYear_sGift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISweets candy1 = new Candy("Choco Bar", 0.2, "Chocolate");
            ISweets candy2 = new Candy("Lollipop", 0.1, "Fruit");
            ISweets candy3 = new Chocolate("Dark Chocolate", 0.3, "Chocolate", "Dark");
            ISweets candy4 = new Chocolate("White Chocolate", 0.25, "Chocolate", "White");
            ISweets candy5 = new Chocolate("Milk Chocolate", 0.35, "Chocolate", "Milk");
            ISweets candy6 = new Candy("Jelly", 0.5, "Fruit");

            ISweets[] giftItems = { candy1, candy2, candy3 };
            Gift newYearGift = new Gift(giftItems);

            Console.WriteLine("Total Gift Weight: " + newYearGift.CalculateTotalWeight().ToString("F2") + " grams");

            newYearGift.SortCandiesByParameter("flavor");

            ISweets? foundCandy = newYearGift.FindCandy(sweet => (sweet as Candy).Flavor == "Chocolate");

            if (foundCandy != null)
            {
                Console.WriteLine("Found Candy: " + foundCandy.Name);
            }
            else
            {
                Console.WriteLine("Candy not found.");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}