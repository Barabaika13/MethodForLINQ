namespace MethodForLINQ
{
    public static class MyExtensions
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percentage)
        {
            if (percentage < 1 || percentage > 100)
            {
                throw new ArgumentException("Введите значение от 1 до 100.");
            }
            int count = collection.Count();
            int numberOfElements = (int)Math.Ceiling(count * (percentage / 100.0));
            var newCollection = collection.OrderByDescending(element => element).Take(numberOfElements);
            return newCollection;

        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percentage, Func<T, int> func)
        {
            if (percentage < 1 || percentage > 100)
            {
                throw new ArgumentException("Введите значение от 1 до 100.");
            }
            int count = collection.Count();
            int numberOfItems = (int)Math.Ceiling(count * (percentage / 100.0));
            var filteredCollection = collection.OrderByDescending(func).Take(numberOfItems);
            return filteredCollection;
        }
    }
}
