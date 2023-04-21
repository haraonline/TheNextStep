using System.Globalization;

namespace _03_ExtensionMethods
{
    internal static class Extensions
    {
        public static int WordCount(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        public static string ToTitleCase(this string str)
        {
            return CultureInfo.CurrentCulture.TextInfo.ToTitleCase(str.ToLower());
        }

        public static string ToSentenceCase(this string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1);
        }

        public static string ToCamelCase(this string str)
        {
            return str.Substring(0, 1).ToLower() + str.Substring(1);
        }       
    }
}
