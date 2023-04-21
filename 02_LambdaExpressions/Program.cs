using System.Linq;

namespace _02_LambdaExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object[] mixture = new object[] { 1, 2, 3, 4, 5, 'c', "Hello", 3.14, new List<int>() { 3,4,5 } };

            // LINQ query
            int allIntegers = mixture.OfType<int>().Count();
            Console.WriteLine($"There are {allIntegers} integers in the mixture.");

            // Lambda expression
            int allIntegers2 = mixture.Count(x => x is int);
            Console.WriteLine($"There are {allIntegers2} integers in the mixture.");
            Console.WriteLine();

            List<string> groceries = new List<string>() { "milk", "eggs", "bread", "butter", "cheese", "yogurt" };

            //difference between select and where
            //where is for filtering and select is for transforming
            var selected = groceries.Select(x => x.ToUpper());
            var filtered = groceries.Where(x => x.Contains("e"));

            Console.WriteLine("SELECTED");
            Console.WriteLine("========");
            foreach (var item in selected)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("FILTERED");
            Console.WriteLine("========");
            foreach (var item in filtered)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine("LAMBDA BUILT-IN FOREACH");
            Console.WriteLine("========");
            //lambda built-in foreach
            groceries.ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            Console.WriteLine("STRINGED GROCERIES");

            //stringed groceries
            string stringedGroceries = groceries.Aggregate((x, y) => x + ", " + y);
            Console.WriteLine(stringedGroceries);

        }
    }
}