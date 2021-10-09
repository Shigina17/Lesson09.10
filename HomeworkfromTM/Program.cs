using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkfromTM4
{
    class Program
    {
        static void Main(string[]args)
        {
            Random rnd = new Random();
            Console.WriteLine("Упражнение 5.1");
            Console.WriteLine("Введите первое число: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Наибольшее число из двух представленных: " + Max(num1, num2));



            Console.WriteLine("Упражнение 5.2");
            Console.WriteLine("Введите первое число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Число один было равно: " + num1 + "\nЧисло два было равно: " + num2);
            Replace(ref num1, ref num2);
            Console.WriteLine("Число один стало равно: " + num1 + "\nЧисло два стало равно: " + num2);



            Console.WriteLine("Упражнение 5.3");
            Console.WriteLine("Введите число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Fact(num1));



            Console.WriteLine("Упражнение 5.4");
            Console.WriteLine("Введите число: ");
            var n = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine($"Факториал числа {n} равен {Factorial(n)}");
            


            Console.WriteLine("Домашнее задание 5.1");
            Console.WriteLine("Алгоритм Евклида для двух чисел");
            Console.WriteLine("Первое число: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Наибольший общий делитель чисел {a} и {b} равен {Nod(a, b)}");
            Console.WriteLine("Алгоритм Евклида для трёх чисел");
            Console.WriteLine("Первое число: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Второе число: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Третье число: ");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Наибольший общий делитель чисел {a} и {b} и {c} равен {Nod(Nod(a, b), c)}");



            Console.WriteLine("Домашнее задание 5.2");
            Console.WriteLine("Введите число: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Значение выбранного числа ряда Фибоначчи составило: {Fib(num1)}");
            Console.ReadKey();
        }
        static int Max(int num1, int num2)
        {
        if (num1 > num2)
            return num1;
        else
            return num2;
        }
        static void Replace(ref int num1, ref int num2)
        {
            int n = num1;
            num1 = num2;
            num2 = n;
        }
        public static bool Fact(int number)
        {
            int result = 1;
            for (int i = 1; i < number; i++)
            {
                try
                {
                    checked // используем для явного включения проверки переполнения
                    {
                        result *= i;
                    }
                }
                catch (Exception) // исключение, если выполнение операции приводит к переполнению
                {
                    result = 0;
                    return false;
                }
            }
            Console.WriteLine(result);
            return true;
        }
        static ulong Factorial(uint n)
        {
            return n == 0 ? 1 : Factorial(n - 1) * n;
            /* если не использовать тернарный оператор получим:
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return Factorial(n - 1) * n;
            }
            */
        }
        static int Nod(int a, int b)
        {
            while (b != 0)
            {
                var t = b;
                b = a % b;
                a = t;
            }
            return a;
        }
        static int Fib(int num)
        {
            if (num == 1 || num == 2)
            {
                return 1;
            }
            return Fib(num - 1) + Fib(num - 2);
        }
    }
}