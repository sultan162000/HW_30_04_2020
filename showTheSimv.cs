using System;
namespace HW_30_04
{
    public class showTheSimv
    {
        private int _heightWindow;
        private int _widthWindow;
        private int[] _widthPosSimple;
        private int[] _widthPosAddition;

        private readonly Simvol _sign = new Simvol();

        //ctor
        public showTheSimv() : this((Console.WindowWidth - 1), Console.WindowHeight)
        { }

        public showTheSimv(int windowWidth, int windowHeight)
        {
            Initialization(windowWidth, windowHeight);
        }

        private void Initialization(int windowWidth, int windowHeight)
        {
            //получаем высоту окна
            _heightWindow = windowHeight;

            int h1 = _heightWindow / 2; //половина высоты
            int h2 = _heightWindow / 4; //четверть высоты

            //ширина окна
            _widthWindow = windowWidth;

            //два массива размером в ширину окна
            _widthPosSimple = new int[_widthWindow];
            _widthPosAddition = new int[_widthWindow];

            //заполнение массивов случайными числами
            for (int i = 0; i < _widthWindow; i++)
            {
                _widthPosSimple[i] = Simvol.r.Next(_heightWindow);

                int k = (i % 11 != 10) ? 2 : 1;
                int min = h2 * k;
                int max = h1 * k;
                _widthPosAddition[i] = Simvol.r.Next(min, max);
            }
        }


        
    }
}