namespace _05_Delegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action action = action1;
            action();
        }

        private static void action1()
        {
            Console.WriteLine("action1 called");
        }
    }
}