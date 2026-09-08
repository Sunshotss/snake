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
            int[,] list2 = new int[6, 6];

            int x = 2;
            int y = 2;
            int tail = 3;

            while (true)
            {
                if (KeyAvailable)
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.W)
                    {
                        list2[y, x] = 1;
                        list[y, x - 1] = 2;
                        x--;
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        list2[y, x] = 2;
                        list[y - 1, x] = 2;
                        y--;
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        list2[y, x] = 3;
                        list[y, x + 1] = 2;
                        x++;
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        list2[y, x] = 4;
                        list[y + 1, x] = 2; 
                        y++; 
                    }
                }

                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        Console.SetCursorPosition(j, i);

                        Console.Write($"{list[j, i]}");
                    }
                }
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        if (list2[j, i] == 1)
                        {
                            Console.SetCursorPosition(j, i);
                            Console.Write(" ");
                            list[j, i] = 0;
                            list[j, i - 1] = 2;
                        }
                        if (list2[j, i] == 2)
                        {
                            Console.SetCursorPosition(j, i);
                            Console.Write(" ");
                            list[j, i] = 0;
                            list[j - 1, i] = 2;
                        }
                        if (list2[j, i] == 3)
                        {
                            Console.SetCursorPosition(j, i);
                            Console.Write(" ");
                            list[j, i] = 0;
                            list[j, i + 1] = 2;
                        }
                        if (list2[j, i] == 4)
                        {
                            Console.SetCursorPosition(j, i);
                            Console.Write(" ");
                            list[j, i] = 0;
                            list[j + 1, i] = 2;
                        }


                        Console.SetCursorPosition(y + 10, x + 10);

                        Console.Write($"{list[y, x]}");
                    }
                }
            }
        }
    }
}
