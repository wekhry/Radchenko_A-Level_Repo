using EventsHW.Publisher;

namespace EventsHW.Receiver
{
    public class LetterReceiver
    {
        public void HandleLetterArrived(object sender, ItemEventArgs e)
        {
            var firstLetter = e.Items.FirstOrDefault2(item => item.StartsWith("L"));
            Console.WriteLine($"First item starting with 'L': {firstLetter}");

            var skippedItems = e.Items.SkipWhile2(item => item.Length < 2).Skip(1);
            Console.WriteLine("Skipped items: ");
            foreach( var item in skippedItems )
            {
                Console.WriteLine(item);
            }
        }
    }
}
