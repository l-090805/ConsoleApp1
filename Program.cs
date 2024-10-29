namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Valori initaile: a={a} b={b}");

            (a,b)=(b,a);
            Console.WriteLine($"Valori dupa swap: a={a} b={b}");
        }
    }
}
