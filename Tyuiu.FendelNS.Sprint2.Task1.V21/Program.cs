using Tyuiu.FendelNS.Sprint2.Task1.V21.Lib;

namespace Tyuiu.FendelNS.Sprint2.Task1.V21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            int a = 696;
            int b = 987;
            int c = 696;
            int d = 155;

            bool[] res = new bool[6];
            res = ds.GetLogicOperations(a, b, c, d);

            Console.Title = "Спринт #2 | Выполнил: Фендель Н. C. | СМАРТб-24-1";
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("* Спринт #2                                                                                                            *");
            Console.WriteLine("* Тема: Логические операции                                                                                            *");
            Console.WriteLine("* Задание #1                                                                                                           *");
            Console.WriteLine("* Вариант #21                                                                                                          *");
            Console.WriteLine("* Выполнил: Фендель Николай Сергеевич| СМАРТб-24-1                                                                      *");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                                             *");
            Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=, последовательность можно чередовать,                 *");
            Console.WriteLine("* но использовать один раз в выражении)                                                                                *");
            Console.WriteLine("* и логических операций (|, &, ||, &&, !, ^, последовательность операций не должна нарушаться),                        *");
            Console.WriteLine("* а также арифметических выражений, которая вернет логическую последовательность(массив):                              *");
            Console.WriteLine("* (False, False, False, False, True, False), при a = 696, b = 987, c = 696, d = 155                                    *");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                                     *");
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("a = " + a);
            Console.WriteLine("b = " + b);
            Console.WriteLine("c = " + c);
            Console.WriteLine("d = " + d);
            Console.WriteLine("************************************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                                           *");
            Console.WriteLine("************************************************************************************************************************");
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(res[i]);
            }
            Console.ReadKey();
        }
    }
}