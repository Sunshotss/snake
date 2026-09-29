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
            int leng = 3;

            int width = 10;
            int height = 10;
            List<Vector2> positions = new List<Vector2>();

            Random rnd = new Random();
            bool appels = true;
            Vector2 appel;
            appel.X = 2;
            appel.Y = 2;

            while (true)
            {
                if (appels)
                {
                    appel.X = rnd.Next(height);
                    appel.Y = rnd.Next(width);

                    Console.SetCursorPosition((int)appel.X, (int)appel.Y);
                    Console.Write("A");
                    appels = false;
                }
                if (!appels)
                {
                    if (appel.X == xy.X && appel.Y == xy.Y)
                    {
                        leng++;
                        appels = true;
                    }
                }

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
                if (tail.Count > leng)
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
                Console.SetCursorPosition(5, 20);
                Console.Write($"{leng}");
                Console.SetCursorPosition(10, 20);
                Console.Write($"{appel.X} {xy.X}");
                Console.SetCursorPosition(15, 20);
                Console.Write($"{appel.Y} {xy.Y}");
                for (int i = 0; i < height; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Vector2 vector;
                        vector.X = i;
                        vector.Y = j;
                        positions.Add(vector);
                        for (int l = 0; l < tail.Count; l++)
                        {

                        }

                    }
                }
            }
        }
    }
}
