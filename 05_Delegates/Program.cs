namespace _05_Delegates
{

    //Funk<> and Action<T> are generic delegates that can be used to represent methods that return void and take up to 16 parameters ???

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