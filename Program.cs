using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Numerics;
using static System.Console;

namespace sanpe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stoping = new();
            stoping.Start();

            bool dead = false;
            int inte = 0;
            
            ConsoleKeyInfo key;
            Vector2 headdir = new(1, 0);
            int leng = 3;
            List<Vector2> tail = new List<Vector2>();
            Vector2 headpos = new(2, 2);



            CursorVisible = false;

            int width = 10;
            int height = 10;
            List<Vector2> positions = new List<Vector2>();

            Random rnd = new Random();
            bool appels = true;
            Vector2 appel = new(2, 2);


            for (int i = 0; i < width; i++)
            {
                Console.SetCursorPosition(i, height);
                Console.Write("%");
            }
            for (int j = 0; j < height; j++)
            {
                Console.SetCursorPosition(width, j);
                Console.Write("%");
            }


            while (true)
            {
                if (stoping.ElapsedMilliseconds < 192)
                {
                    continue;
                }

                stoping.Restart();

                if (KeyAvailable)
                {
                    key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.W)
                    {
                        headdir = new(0, -1);
                    }
                    if (key.Key == ConsoleKey.A)
                    {
                        headdir = new(-1, 0);
                    }
                    if (key.Key == ConsoleKey.S)
                    {
                        headdir = new(0, 1);
                    }
                    if (key.Key == ConsoleKey.D)
                    {
                        headdir = new(1, 0);
                    }
                }
                headpos += headdir;
                if (headpos.Y < 0) dead = true;
                if (headpos.X < 0) dead = true;
                if (headpos.Y >= width) dead = true;
                if (headpos.X >= height) dead = true;
                tail.Add(headpos);


                //making sure appels spawn not on snake
                positions.Clear();
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        Vector2 pos = new(i, j);
                        bool isInSnake = false;
                        for (int l = 0; l < tail.Count; l++)
                        {
                            if (tail[l] == pos)
                            {
                                isInSnake = true;
                                break;
                            }
                        }
                        if (!isInSnake) positions.Add(pos);
                    }
                }
                //making sure appels spawn not on snake

                //appels
                Console.SetCursorPosition(30,10);
                Console.Write(" ");
                Console.SetCursorPosition(31, 10);
                Console.Write(" ");
                Console.SetCursorPosition(32, 10);
                Console.Write(" ");
                Console.SetCursorPosition(30, 10);
                Console.Write(positions.Count);
                if (appels)
                {
                    var randompos = positions[rnd.Next(positions.Count)];
                    appel.X = randompos.X;
                    appel.Y = randompos.Y;
                    Console.SetCursorPosition((int)appel.X, (int)appel.Y);


                    Console.Write("A");
                    appels = false;
                }
                if (!appels) //collision?
                {
                    if (appel.X == headpos.X && appel.Y == headpos.Y)
                    {
                        leng++;
                        appels = true;
                    }
                }
                //appels
                
                
                if (tail.Count > leng)
                {
                    SetCursorPosition((int)tail[0].X, (int)tail[0].Y);
                    Console.Write(" ");
                    tail.RemoveAt(0);
                }

                for (int i = 0; i < tail.Count(); i++)
                {
                    Console.SetCursorPosition((int)tail[i].X, (int)tail[i].Y);

                    Console.Write("#");
                }
                Console.SetCursorPosition(5, 20);
                Console.Write($"{leng}");
                Console.SetCursorPosition(10, 20);
                Console.Write($"{appel}" + inte);
                inte++;

                for (int i = 0; i < tail.Count() - 1; i++)
                {
                    if (tail[i] == headpos)
                    {
                        dead = true;
                        break;
                    }
                }
                if (dead == true) break;
            }
        }
    }
}
