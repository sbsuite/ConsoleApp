namespace TestApp
{
    class Program
    {
        static int Main(string[] args)
        {
            foreach (var arg in args)
            {
                System.Console.WriteLine(arg);
            }
            return 1;
        }
    }
}
