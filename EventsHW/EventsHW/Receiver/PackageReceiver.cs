using EventsHW.Publisher;

namespace EventsHW.Receiver
{
    public class PackageReceiver
    {
        public void HandlePackageArrived(object sender, ItemEventArgs e)
        {
            var firstPackage = e.Items.FirstOrDefault2(item => item.StartsWith("P"));
            Console.WriteLine($"First item starting with 'P': {firstPackage}");

            var skippedItems = e.Items.SkipWhile2(item => item.Length < 2).Skip(1);
            Console.WriteLine("Skipped items: ");
            foreach (var item in skippedItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
