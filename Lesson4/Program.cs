using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static int[] BubbleSort(int[] mas)
        {
            int temp;
            int i;
            for (i = 0; i < mas.Length; i++) ;
            {
                for (int j = i + 1; j < mas.Length; j++)
                {
                    if (mas[i] > mas[j])
                    {
                        temp = mas[i];
                        mas[i] = mas[j];
                        mas[j] = temp;
                    }
                }
            }
            return mas;
        }
        static int Params(params int[] mas)
        {
            int sum = 0;
            for (int i = 0; i < mas.Length; i++)
            {
                sum += mas[i]; // находим сумму элементов массива
            }
            return sum;
        }
        static ulong Multiplication_Mas(ref int[] mas) // ref - значение передается по ссылке
        {                                              // ulong 8 byte
            ulong multip = 1;
            for (int i = 0; i < mas.Length; i++)
            {
                multip *= (ulong)mas[i]; 
            }
            return multip;
        }
        static void Arithmetic_meanOfMas(int[] mas, out double arifm) // out- значение передается по значению
        {
            int sum = Params(mas);
            arifm = (double)sum / mas.Length;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("Решение квадратного уравнения: ");
            Console.WriteLine("Введите переменную a: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную c: ");
            int c = int.Parse(Console.ReadLine());
            Discriminant(a, b, c);
            Console.ReadKey();



            Console.WriteLine("Задание 2");
            Random rnd = new Random(); //создаем рандом
            int[] array = new int[20]; //создаем массив
            int i;
            for (i = 0; i < array.Length; i++);
            {
                array[i] = rnd.Next(0, 50);
                Console.WriteLine(array[i]); //заполняем его случайными числами
            }
            Console.WriteLine("Введите номера чисел, которые хотите поменять, от 1 до 20");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = array[a];
            array[a] = array[b];
            array[b] = c;
            Console.WriteLine("Массив после изменения: ");
            for (i = 0; i < array.Length; i++); //вывод массива
            {
                Console.WriteLine(array[i]);
            }



            Console.WriteLine("Задание 3");
            Console.WriteLine("Сколько чисел будем сортировать?");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите числа для сортировки: ");
            int[] mas = new int[N];
            for (i = 0; i < mas.Length; i++)
            {
                mas[i] = Convert.ToInt32(Console.ReadLine());
            }
            BubbleSort(mas);
            Console.WriteLine("Массив после сортировки: ");
            for (i = 0; i < mas.Length; i++);
            {
                Console.WriteLine(mas[i]);
            }



            Console.WriteLine("Задание 4");
            int sum = Params(mas);
            Console.WriteLine($"Сумма = {sum}");
            Console.WriteLine("\nПпроизведение: " + Multiplication_Mas(ref mas));
            double arifm;
            Arithmetic_meanOfMas(mas, out arifm);
            Console.WriteLine("\nСреднее арифметичексое: " + arifm);



            Console.WriteLine("Задание 5");
            string zero = "   ######### \n" +
                            "##       ##\n" +
                            "##       ##\n" +
                            "##       ##\n" +
                            "##       ##\n" +
                            "##       ##\n" +
                            " ######### ";

            string one = "    ###   \n" +
                         "   ####   \n" +
                         "  ## ##   \n" +
                         "     ##   \n" +
                         "     ##   \n" +
                         "   ######   ";

            string two = "       ####  \n" +
                         "    ###  ### \n" +
                         "   ##    ##  \n" +
                         "        ##   \n" +
                         "       ##    \n" +
                         "      ##     \n" +
                         "   ########  \n";


            string three = "  #####  \n" +
                           " ##  ### \n" +
                           "      ## \n" +
                           "    #### \n" +
                           " ######  \n" +
                           "    #### \n" +
                           "      ## \n" +
                           " ##  ### \n" +
                           "  #####    ";

            string four = "  ##   ## \n" +
                          "  ##   ## \n" +
                          "  ##   ## \n" +
                          "   ###### \n" +
                          "      ### \n" +
                          "       ## \n" +
                          "       ## \n" +
                          "       ##   ";

            string five = "   ########   \n" +
                          "   ##         \n" +
                          "   ##         \n" +
                          "   #######    \n" +
                          "   ##   ###  \n" +
                          "         ### \n" +
                          "        ###  \n" +
                          "   ###### ";

            string six = "      #####    \n" +
                          "   ###  ###  \n" +
                          "  ###    ##  \n" +
                          "  ##   ###   \n" +
                          "  ###         \n" +
                          "  ########   \n" +
                          "  ##     ##  \n" +
                          "   ##     ## \n" +
                          "    #######    ";

            string seven = "  ########  \n" +
                           " ##    ### \n" +
                           "###     ## \n" +
                           "      ###  \n" +
                           "     ###   \n" +
                           " ######### \n" +
                           "   ####    \n" +
                           "  ###      \n" +
                           " ###       ";

            string eight = "   #######   \n" +
                           " ###    ### \n" +
                           "###      ## \n" +
                           " ###   ###  \n" +
                           "  ######    \n" +
                           " ###   ###  \n" +
                           "###     ##  \n" +
                           " ###  ###   \n" +
                           "  #####       ";


            string nine = " ########   \n" +
                          "###    ### \n" +
                          "##      ## \n" +
                          " ##### ##  \n" +
                          "      ###  \n" +
                          "      ###  \n" +
                          "##   ###   \n" +
                          " #####    ";
            int number;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите число от 0 до 9 или exit(Закрыть)");
                    string str = Console.ReadLine().ToLower();
                    if (str == "exit" || str == "закрыть")
                    {
                        break;
                    }
                    number = Convert.ToInt32(str);
                    switch (number)
                    {
                        case 0:
                            Console.WriteLine(zero);
                            break;
                        case 1:
                            Console.WriteLine(one);
                            break;
                        case 2:
                            Console.WriteLine(two);
                            break;
                        case 3:
                            Console.WriteLine(three);
                            break;
                        case 4:
                            Console.WriteLine(four);
                            break;
                        case 5:
                            Console.WriteLine(five);
                            break;
                        case 6:
                            Console.WriteLine(six);
                            break;
                        case 7:
                            Console.WriteLine(seven);
                            break;
                        case 8:
                            Console.WriteLine(eight);
                            break;
                        case 9:
                            Console.WriteLine(nine);
                            break;
                        default:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine("Error");
                            System.Threading.Thread.Sleep(3000);
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.BackgroundColor = ConsoleColor.Black;
                            Console.Clear();
                            Console.WriteLine("Error");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("Error - Вы ввели не цифру");
                    System.Threading.Thread.Sleep(3000);
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.WriteLine("Error - Вы ввели не цифру");
                    Console.ReadKey();
                }
            }
        }
        private static void Discriminant(double a, double b, double c)
        {
            double discriminant, x1, x2;
            //дискриминант
            discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("Квадратное уравнение не имеет корней");
            }
            else if (discriminant == 0) // квадратное уравнение имеет два одинаковых корня
            {
                x1 = -b / (2 * a);
                x2 = x1;
                Console.WriteLine($"x1 = {x1}; x2 = {x2}");
            }
            else // уравнение имеет два разных корня
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"Корни уравнения такие: x1 = {x1}; x2 = {x2}");  // вывод корней уравнения
            }
        }
    }
}


