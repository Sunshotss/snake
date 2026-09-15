using System.Numerics;
using static System.Console;

namespace sanpe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CursorVisible = false;
            ConsoleKeyInfo key;
            List<Vector2> tail = new List<Vector2>();
            Vector2 xy;
            xy.X = 2;
            xy.Y = 2;
            int leng = 10;

            while (true)
            {
                if (KeyAvailable)
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.W)
                    {
                        xy.Y--;
                        tail.Add(xy);
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        xy.X--;
                        tail.Add(xy);
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        xy.Y++;
                        tail.Add(xy);
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        xy.X++;
                        tail.Add(xy);
                    }
                }
                if (tail.Count >= leng)
                {
                    SetCursorPosition((int)tail[0].X, (int)tail[0].Y);
                    Console.Write(" ");
                    tail.RemoveAt(0);
                }
                for (int i = 0; i < tail.Count(); i++)
                {
                    Console.SetCursorPosition((int)tail[i].X, (int)tail[i].Y);

                    Console.Write("1");
                }
            }
        }
    }
}
