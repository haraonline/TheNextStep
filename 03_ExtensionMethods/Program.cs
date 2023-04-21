namespace _03_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "The quick fox jumped over the lazy dog.";

            int wordCount = Extensions.WordCount(str);
            string titleCase = Extensions.ToTitleCase(str);
            string sentenceCase = Extensions.ToSentenceCase(str);
            string camelCase = Extensions.ToCamelCase(str);

            Console.WriteLine("Word Count: {0}", wordCount);
            Console.WriteLine("Title Case: {0}", titleCase);
            Console.WriteLine("Sentence Case: {0}", sentenceCase);
            Console.WriteLine("Camel Case: {0}", camelCase);
        }
    }
}