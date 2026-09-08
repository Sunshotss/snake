using static System.Console;

namespace sanpe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CursorVisible = false;
            ConsoleKeyInfo key;
            int[,] list = {
                { 1, 1, 1, 1, 1, 1  },
                { 1, 1, 1, 1, 1, 1  },
                { 1, 1, 1, 1, 1, 1  },
                { 1, 1, 1, 1, 1, 1  },
                { 1, 1, 1, 1, 1, 1  },
                { 1, 1, 1, 1, 1, 1  },
            };

            int x = 2;
            int y = 2;

            while (true)
            {
                if (KeyAvailable)
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.A)
                    {
                        list[y - 1, x] = 2;
                        y--; 
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        list[y + 1, x] = 2; 
                        y++; 
                    }
                }
                Console.SetCursorPosition(5, 5);

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.SetCursorPosition(j, i);

                        Console.Write($"{list[j, i]}");
                    }
                }
            }
        }
    }
}
