using EventsHW.Publisher;

namespace EventsHW.Receiver
{
    public class MagazineReceiver
    {
        public void HandleMagazineArrived(object sender, ItemEventArgs e)
        {
            var firstMagazine = e.Items.FirstOrDefault2(item => item.StartsWith("M"));
            Console.WriteLine($"First item starting with 'M': {firstMagazine}");

            var skippedItems = e.Items.SkipWhile2(items => items.Length < 2).Skip(1);
            Console.WriteLine("Skipped items: ");
            foreach (var items in skippedItems)
            {
                Console.WriteLine(items);
            }
        }
    }
}
