namespace EventsHW.Publisher
{
    public class ItemEventArgs : EventArgs
    {
        public IEnumerable<string> Items {  get; }

        public ItemEventArgs(IEnumerable<string> items)
        {
            Items = items;
        }
    }
}
