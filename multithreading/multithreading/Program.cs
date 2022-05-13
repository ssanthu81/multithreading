using System.Threading;
class Profram
{
    static void test()
    {
        for (int i = 1; i <= 100; i++)
            Console.WriteLine("test:" + i);
    }
    static void Main(string[] args)
    {
        Profram t = new Profram();
        test();
        Console.ReadLine();
    }
}