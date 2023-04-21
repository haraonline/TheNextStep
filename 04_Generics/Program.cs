namespace _04_Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool areEqual = AreEqual(true, false); //false
            //bool areEqual = AreEqual(1, 1); //true
            //bool areEqual = AreEqual('c', 'a'); //false
            bool areEqual = AreEqual("Harry", "harry"); //false

            Console.WriteLine(areEqual);

        }

        public static bool AreEqual<T>(T first, T second) where T: IComparable<T>
        {
            return first.CompareTo(second) == 0;
        }
    }
}