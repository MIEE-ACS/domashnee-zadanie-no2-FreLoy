using System;

namespace DZ2
{
    class Program
    {
        static void Main(string[] args)
        {

            double y;
            double y1;
            double x1;
            Console.WriteLine($" Введите значение R: ");
            double R = Double.Parse(Console.ReadLine());
        
            for (double x = -10; x <= 8; x += 0.2)
            {
                 refactoring(ref R, x);
            }
            while(true)
            {
                Console.WriteLine($" Введите значение x: ");
                double H = Double.Parse(Console.ReadLine());
                refactoring(ref R, H);
            }

            //расчет  первого сегмента графика
            static double segment1(double x)
            {
                //отрезок
                double y;
                y = 0.5 * (-x - 6);

                return y;
            }

            //расчет  второго сегмента графика
            static double segment2(double x, double R)
            {
                //центр окружности (0;0)
                double y;
                //по уравнению окружности
                y = Math.Sqrt(Math.Pow(R, 2) - Math.Sqrt(Math.Pow(1, 2)));

                //возвращаем значение в нижней четверти
                return -y;
            }
            //расчет  третьего сегмента графика
            static double segment3(double x, double R)
            {
                // центр окружности(3;0)
                double a = 3;
                double b = 0;
                double y;
                //по уравнению окружности
                y = Math.Sqrt(R * R - (x - a) * (x - a)) - b;



                //возвращаем значение в ВЕРХНЕЙ четверти
                return y;
            }
        }

        static void refactoring(ref double R, double x)
        {
            double y;
            if (x > -10 && x <= 0)

            {
                y = Math.Round(0.5 * (-x - 6), 5);
                Console.WriteLine($"{y}");
            }

            else if (x > 0 && x <= 3)
            {

                y = -Math.Round((Math.Sqrt(Math.Pow(R, 2) - Math.Sqrt(Math.Pow(1, 2)))), 5);
                Console.WriteLine($"{y}");
            }
            else if (x > 3 && x < 6)
            {

                if (R < 3)
                {
                    Console.WriteLine("Появилась точка разрыва 2-ого рода - ФУНКЦИЯ НЕОПРЕДЕЛЕНА");

                }
                else if (R > 3)
                {
                    double del;
                    del = Math.Sqrt(R * R - 9);
                    y = Math.Round(Math.Sqrt(R * R - x * x));
                    Console.WriteLine($"{y}");

                }
                else R = 3;
                {
                    y = Math.Round((Math.Sqrt(Math.Pow(R, 2) - Math.Sqrt(Math.Pow(1, 2)))), 5);
                    Console.WriteLine($"{y}");
                }
            }
            else if (x == 6)
            {
                y = 3;
                Console.WriteLine($"{y} точка разрыва 1-ого рода");
                y = 0;
                Console.WriteLine($"{y} точка разрыва 1-ого рода");
            }
            else if (x > 6 && x <= 8)
            {
                y = 0;

                Console.WriteLine($"{y}");
            }
            else
            {
                Console.WriteLine("Функция не определена");
            }

           
        }

        //расчет  четвертого сегмента графика
        static double segment4(double x)
        {

            double y;

            y = 3;

            return y;
        }
        //расчет  четвертого сегмента графика
        static double segment41(double x)
        {
            double y1;
            y1 = 0;
            return y1;
        }
        //расчет  пятого сегмента графика
        static double segment5(double x,double x1)
        {
            double y;
            x = 6;
            x1 = 8;
            y = 0;
                return y;

        }
    }
}




















