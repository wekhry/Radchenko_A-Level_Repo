using EventsHW.Publisher;

namespace EventsHW.Receiver
{
    public class NewsPaperReceiver
    {
        public void HandleNewsPaperArrived(object sender, ItemEventArgs e)
        {
            var firstNewsPaper = e.Items.FirstOrDefault2(item => item.StartsWith("N"));
            Console.WriteLine($"First item starting with 'N': {firstNewsPaper}");

            var skippedItems = e.Items.SkipWhile2(item => item.Length < 2).Skip(1);
            Console.WriteLine("Skipped items: ");
            foreach (var item in skippedItems)
            {
                Console.WriteLine(item);
            }
        }
    }
}
