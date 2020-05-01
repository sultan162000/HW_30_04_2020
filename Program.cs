using System;

namespace HW_30_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int second = 0;
            showTheSimv show = new showTheSimv();
            Console.Clear();
            Console.CursorVisible = false;
            while (true)
            {
                DateTime time = DateTime.Now;
                show.ShowSimvol();
                second = 150 - (int)((TimeSpan)(DateTime.Now - time)).TotalMilliseconds;
                if (second > 0) System.Threading.Thread.Sleep(second);
            }
            
        }
    }
}