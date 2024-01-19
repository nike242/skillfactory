using System.Drawing;

namespace start
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intYear;
            int currentYear = DateTime.Now.Year;
            Console.WriteLine("Как вас зовут?");
            string name  = Console.ReadLine();

            while (true)
            {
                Console.WriteLine("Введите ваш год рождения: ");
                string yearBd = Console.ReadLine();
                if (int.TryParse(yearBd, out intYear) && intYear.ToString().Length == 4)
                {

                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели не число, либо некорректный формат года. Попробуйте ещё раз.");
                }
            }
            int realAge = currentYear - intYear;
            int customAge = realAge--;

            while (true)
            {
                Console.WriteLine("Вы уже изучили C#? Варианты ответов Да/Нет/Y/N/Yes/No");
                string isSuperman = Console.ReadLine();
                if (String.Equals(isSuperman, "да", StringComparison.OrdinalIgnoreCase) || String.Equals(isSuperman, "y", StringComparison.OrdinalIgnoreCase) || String.Equals(isSuperman, "yes", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Здравствуйте, {0}. Это прекрасно, вам всего {1} (или {2}), а вы уже знаете программирование!", name, realAge, customAge);
                    break;
                }
                else if (String.Equals(isSuperman, "нет", StringComparison.OrdinalIgnoreCase) || String.Equals(isSuperman, "n", StringComparison.OrdinalIgnoreCase) || String.Equals(isSuperman, "no", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Здравствуйте, {0}. Ничего, ведь вам всего {1} (или {2}). Всё ещё впереди!", name, realAge, customAge);
                    break;
                }
                else
                {
                    Console.WriteLine("Вы ввели некорректный вариант. Попробуйте ещё раз.");
                }
            }


        }
    }
}
