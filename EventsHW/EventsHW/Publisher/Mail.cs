namespace EventsHW.Publisher
{
    public class Mail
    {
        public event EventHandler<ItemEventArgs> ItemArrived;
        public void ProcessItem(IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                try
                {
                    if (IsValidItem(item))
                    {
                        OnItemArrived(new ItemEventArgs(items));
                    }
                    else
                    {
                        throw new ArgumentException($"Invalid item type: {item}");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error processing item: {ex.Message}");
                }
            } 
        }

        private bool IsValidItem(string item)
        {
            return item == "Letter" || item == "Magazine" || item == "Package" || item == "NewsPaper";
        }

        protected virtual void OnItemArrived(ItemEventArgs e)
        {
            try
            {
                ItemArrived?.Invoke(this, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error processing item: {ex.Message}");
            }
        }
    }
}
