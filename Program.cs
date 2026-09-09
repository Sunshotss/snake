using static System.Console;

namespace sanpe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CursorVisible = false;
            ConsoleKeyInfo key;
            List <(y, x)> snake = new List<(y, x)>();
            int y = 2;
            int x = 2;
            int tail = 3;

            while (true)
            {
                if (KeyAvailable)
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.W)
                    {
                        y--;
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        x--;
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        y++;
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        x++;
                    }
                }
                snake.Add(y, x);


                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.SetCursorPosition(j, i);
                        Console.Write(" ");

                        Console.SetCursorPosition(y, x);
                        Console.Write($"{snake[y, x]}");
                    }
                }
            }
        }
    }
}
