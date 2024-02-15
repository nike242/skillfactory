using System;

namespace module_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task4116();
        }

        //static void Task414 ()
        //{
        //    string a;
        //    string b;

        //    bool c = a != b;

        //    Console.WriteLine(c);
        //    Console.ReadKey();
        //}

        //static void Task415()
        //{
        //    int a;
        //    int b;
        //    double x;
        //    double y;

        //    bool c = (a < b) | (x > y);

        //    Console.WriteLine(c);
        //    Console.ReadKey();
        //}

        static void Task4110()
        {
            var inv = true;
            var result = !inv;

            Console.WriteLine(result);
            Console.ReadKey();
        }

        static void Task4111()
        {
            var a = 6;
            var b = 7 - 1;

            if (a == b)
            {
                Console.WriteLine("Условие истинно");
            }
            else
            {
                Console.WriteLine("Условие ложно");
            }
        }

        static void Task4114()
        {
            var a = 6;
            var b = 7;

            if (a == b && b > 1)
            {
                Console.WriteLine("Условие истинно");
            }

            else if (b > 10 || b == 7)
            {
                Console.WriteLine("Значение b = {0} больше 10 или равно 7", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0}", b);
            }
        }

        static void Task4115()
        {
            var a = 6;
            var b = 7;

            var c = a != b ? a + b : b;

            Console.WriteLine(c);
        }

        static void Task4116()
        {
            Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");

            var color = Console.ReadLine();

            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }
        }
    }
}
