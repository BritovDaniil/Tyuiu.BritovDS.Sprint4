using Tyuiu.BritovDS.Sprint4.Task6.V5.Lib;

namespace Tyuiu.BritovDS.Sprint4.Task6.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #4 | Выполнил: Бритов Д. С. | ИСПб-25-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Класс Array                                                       *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #5                                                              *");
            Console.WriteLine("* Выполнил: Бритов Д. С. | ИСПб-25-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан строковый массив данных:                                            *");
            Console.WriteLine("* из планет                                                               *");
            Console.WriteLine("* Используя класс Array, подсчитайте количество элементов,                *");
            Console.WriteLine("* найти длина которых равна 5.                                            *");

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            string[] array = { "Меркурий", "Венера", "Земля", "Марс", "Юпитер", "Сатурн", "Уран", "Нептун" };

            Console.WriteLine("Массив:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"[{i + 1}] {array[i]} (длина: {array[i].Length})");
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            int count = ds.Calculate(array);

            Console.WriteLine($"Количество элементов с длиной 5: {count}");

            Console.ReadKey();
        }
    }
}