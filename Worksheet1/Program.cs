namespace Worksheet1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static void PrintIntegersFor(int[] args)
        {
            int num1 = 40;
            Console.WriteLine(num1);
            for (num1 < 60)
                num1 = num1 + 1;
        }
    }
}