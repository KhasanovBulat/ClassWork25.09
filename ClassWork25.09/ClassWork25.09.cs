using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork25._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1");
            Console.WriteLine("Введите трехзначное число");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number < 1000 && number >= 100)
            {
                int hundreds = number / 100;
                int ones = number % 10;
                if (hundreds == ones)
                {
                    Console.WriteLine("{0} - палиндром", number);
                }
                else
                {
                    Console.WriteLine("{0} - не палиндром", number);
                }
            }
            else
            {
                Console.WriteLine("Ошибка.Введите число от 100 до 999");
            }

            Console.WriteLine("Task 2");
            Console.WriteLine("Введите размеры форточки (а,b) в см:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите диаметр головы Васи в см:");
            int d = Convert.ToInt32(Console.ReadLine());
            int m;
            if (a < b)
            {
                m = a + 2;
            }
            else
            {
                m = b + 2;
            }
            if (d <= m)
            {
                Console.WriteLine("Голова проходит");
            }
            else
            {
                Console.WriteLine("Голова не проходит");
            }


            Console.WriteLine("Task 3");
            Console.WriteLine("Введите порядковый номер дня недели");
            int n = Convert.ToInt32(Console.ReadLine());
            switch (n)
            {
                case 1:
                    Console.WriteLine("Понедельник");
                    break;
                case 2:
                    Console.WriteLine("Вторник");
                    break;
                case 3:
                    Console.WriteLine("Среда");
                    break;
                case 4:
                    Console.WriteLine("Четверг");
                    break;
                case 5:
                    Console.WriteLine("Пятница");
                    break;
                case 6:
                    Console.WriteLine("Суббота");
                    break;
                case 7:
                    Console.WriteLine("Воскресенье");
                    break;
                default:
                    Console.WriteLine("Ошибка. В неделе 7 дней.");
                    break;
            }

            Console.WriteLine("Task 4");
            try
            {
                string[] playingcards = { "шестёрка", "семёрка", "восьмёрка", "девятка", "десятка", "валет", "дама", "король", "туз" };
                Console.WriteLine("Введите номер игральной карты");
                int card_number = Convert.ToInt32(Console.ReadLine());
                string card_name = playingcards[card_number - 6];
                Console.WriteLine("Это {0}", card_name);
            }
            catch (Exception)
            {
                Console.WriteLine("Ошибка. Введите число от 6 до 14");
            }

            Console.WriteLine("Task 5");
            Console.WriteLine("Введите высоту точки над Землёй (в км) от 1 до 10");
            double height = Convert.ToDouble(Console.ReadLine());
            double R = 6370;
            double H = Math.Sqrt((R + height) * (R + height) - R * R);
            if (height >= 1 && height <= 10)
            {
                Console.WriteLine("Расстояние до линии горизонта равно {0}", H);
            }
            else
            {
                Console.WriteLine("Высота должна принимать значения от 1 до 10 (в км)");
            }

            Console.WriteLine("Task 6");
            Console.WriteLine("Введите число");
            n = Convert.ToInt32(Console.ReadLine());
            for (b = 1; b < 10; b++)
            {
                Console.WriteLine("{0}*{1} = {2}", n, b, n * b);
            }

            Console.WriteLine("Task 7");
            try
            {
                Console.WriteLine("Введите целое число");
                int IntegerNumber = Convert.ToInt32(Console.ReadLine());
                int num = 0; int NumberSum = 0;
                while (IntegerNumber >= 0)
                {
                    NumberSum += IntegerNumber;
                    num++;
                    IntegerNumber = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine("Среднее арифметическое - {0}", NumberSum / num);
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }

            Console.WriteLine("Task 8"); // Выводит фразу до тех пор пока не найдет наруш.число (?)
            int[] Sequence = new int[10];
            Console.WriteLine("Введите последовательность:");
            for (int i = 0; i < 10; i++)
            {
                Sequence[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 9; i++)
            {
                if (Sequence[i] > Sequence[i + 1])
                {
                    Console.WriteLine("Номер первого нарушающего данную последовательность элемента - {0} ", i + 2);
                    break;
                }
                else
                {
                    Console.WriteLine("Последовательность возрастающая");
                }

            }

            Console.WriteLine("Task 9"); // ? После ввода элементов неверно считает сумму
            Console.WriteLine("Введите количество элементов в массиве");
            n = Convert.ToInt32(Console.ReadLine());
            int[] SequenceInteger = new int[n];
            SequenceInteger[n - 1] = 0;
            int sum = 0;
            Console.WriteLine("Введите элементы массива");
            for (int i = 0; i < (n - 1); i++)
            {
                SequenceInteger[i] = Convert.ToInt32(Console.ReadLine());
                if (i % 3 != 0) continue;
                sum += SequenceInteger[i];
            }
            Console.WriteLine("sum = {0}", sum);

            Console.WriteLine("Task 10");
            sum = 0;
        Begin:
            int N = Convert.ToInt32(Console.ReadLine());
            if (N != 0)
            {
                sum += N;
                goto Begin;
            }
            Console.WriteLine("Сумма - {0}", sum);




        }
    }
}