using System;

namespace AlgLab3.Tools
{
    public class ConsoleUtil
    {
        public static void ClearScreen()
        {
            System.Console.BackgroundColor = ConsoleColor.Black;
            for (int i = 0; i < System.Console.WindowHeight; i++)
            {
                System.Console.SetCursorPosition(0, i);
                System.Console.Write(new String(' ', System.Console.WindowWidth));
            }

            System.Console.SetCursorPosition(0, 0);
        }

        public static bool Continue()
        {
            do
            {
                System.Console.WriteLine("\nХотите выйти? [Y/N]");
                ConsoleKeyInfo keyInfo = System.Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.Y | keyInfo.Key == ConsoleKey.N)
                {
                    return !(keyInfo.Key == ConsoleKey.Y);
                }
                else
                {
                    System.Console.WriteLine("Неизвестная клавиша");
                }
            } while (true);
        }

        public static void Pause()
        {
            System.Console.WriteLine("\nДля продолжения нажмите любую клавишу...");
            System.Console.ReadLine();
        }
    }
}