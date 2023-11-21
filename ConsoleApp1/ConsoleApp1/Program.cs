using ConsoleApp1;

namespace Program
{
    internal static class Program
    {
        static void Main()
        {
            if (Math.Abs(surface.count_surface(6) - 113.09733) <= 0.001) Console.WriteLine("test circle passed");

            if (Math.Abs(surface.count_surface(3, 4, 5) - 6) <= 0.001) Console.WriteLine("test right triangle passed");

            if (Math.Abs(surface.count_surface(7, 9, 12) - 31.30495) <= 0.001) Console.WriteLine("test random triangle passed");
        }

    }
}
