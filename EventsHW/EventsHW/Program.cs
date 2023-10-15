using EventsHW.Publisher;
using EventsHW.Receiver;

namespace EventsHW
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Mail mail = new Mail();
            LetterReceiver letterReceiver = new LetterReceiver();
            MagazineReceiver magazineReceiver = new MagazineReceiver();
            PackageReceiver packageReceiver = new PackageReceiver();
            NewsPaperReceiver newsPaperReceiver = new NewsPaperReceiver();

            mail.ItemArrived += letterReceiver.HandleLetterArrived;
            mail.ItemArrived += magazineReceiver.HandleMagazineArrived;
            mail.ItemArrived += packageReceiver.HandlePackageArrived;
            mail.ItemArrived += newsPaperReceiver.HandleNewsPaperArrived;

            List<string> items = new List<string> { "Letter", "Magazine", "Package", "NewsPaper", "Invalid item" };

            mail.ProcessItem(items);
        }
    }
}