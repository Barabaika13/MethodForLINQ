namespace MethodForLINQ
{
    public static class MyExtensions
    {
        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percentage)
        {
            if (percentage < 1 || percentage > 100)
            {
                throw new ArgumentException("Метод принимает значение от 1 до 100.");
            }
            int count = collection.Count();
            int numberOfElements = (int)Math.Ceiling(count * (percentage / 100.0));
            var filteredCollection = collection.OrderByDescending(element => element).Take(numberOfElements);
            return filteredCollection;

        }

        public static IEnumerable<T> Top<T>(this IEnumerable<T> collection, int percentage, Func<T, int> func)
        {
            if (percentage < 1 || percentage > 100)
            {
                throw new ArgumentException("Метод принимает значение от 1 до 100.");
            }
            int count = collection.Count();
            int numberOfElements = (int)Math.Ceiling(count * (percentage / 100.0));
            var filteredCollection = collection.OrderByDescending(func).Take(numberOfElements);
            return filteredCollection;
        }
    }
}
