using System;
namespace HW_30_04
{
    public class Simvol
    {
        public static Random r = new Random();
        char GetSimvol()
        {
            int t = r.Next(10);
            if (t <= 2)
                return (char)('0' + r.Next(10));
            else if (t <= 4)
                return (char)('a' + r.Next(27));
            else if (t <= 6)
                return (char)('A' + r.Next(27));
            else
                return (char)(r.Next(32, 255));
        }
        public void ShowWhite(int left, int top)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(left, top);
            Console.Write(GetSimvol());
        }
        public void ShowGreen(int left, int top)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.SetCursorPosition(left, top);
            Console.Write(GetSimvol());

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void ShowSpace(int left, int top)
        {
            Console.SetCursorPosition(left, top);
            Console.Write(' ');
        }

        public void ShowDarkGreen(int left, int top)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(left, top);
            Console.Write(GetSimvol());

            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}