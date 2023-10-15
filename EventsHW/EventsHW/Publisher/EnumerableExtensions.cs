namespace EventsHW.Publisher
{
    public static class EnumerableExtensions
    {
        public static T FirstOrDefault2<T>(this IEnumerable<T> source,  Func<T, bool> predicate)
        {
            return source.FirstOrDefault(predicate);
        }

        public static IEnumerable<T> SkipWhile2<T>(this IEnumerable<T> source, Func<T, bool> predicate)
        {
            return source.SkipWhile(predicate);
        }
    }
}
