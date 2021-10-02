using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork25._09
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Task 1.1");
            Console.WriteLine("Введите число");
            double number = Convert.ToDouble(Console.ReadLine());
            if (number < 0)
            {
                number = -number;
            }
            Console.WriteLine("Абсолютная величина числа равна {0}", number);

            Console.WriteLine("Task 1.2");
            Console.WriteLine("Введите первое число");
            double n1 = Convert.ToDouble(Console.ReadLine());
            double new_n1;
            if (n1 < 0)
            {
                new_n1 = -n1;
            }
            else
            {
                 new_n1 = n1;
            }
            Console.WriteLine("Введите второе число");
            double n2 = Convert.ToDouble(Console.ReadLine());
            double new_n2;
            if (n2 < 0)
            {
                new_n2 = -n2;
            }
            else
            {
                 new_n2 = n2;
            }
            if (new_n1 > new_n2)
            {
                n1 = new_n1 / 2;
                Console.WriteLine("Первое число, уменьшанное в 2 раза равно {0}", n1);
            }
            else
            {
                Console.WriteLine("Первое число не больше второго по абсолютной величине");
            }

            Console.WriteLine("Task 1.3");
            Console.WriteLine("Введите название животного");
            string animal_name = Convert.ToString(Console.ReadLine());
            string MouthSize = "wide";
            if (animal_name == "аллигатор")
            {
                MouthSize = "small";
            }
            Console.WriteLine(MouthSize);

            Console.WriteLine("Task 1.4"); // Как не учитывать регистры?
            string input = Convert.ToString(Console.ReadLine());
            try
            {
                switch (input)
                {
                    case "Jabroni":
                        Console.WriteLine("PatronTequila");
                        break;
                    case "School Counselor":
                        Console.WriteLine("PAnything with Alcohol");
                        break;
                    case "Programmer":
                        Console.WriteLine("Hipster Craft Beer");
                        break;
                    case "Bike Gang Member":
                        Console.WriteLine("Moonshine");
                        break;
                    case "Politician":
                        Console.WriteLine("Your tax dollars");
                        break;
                    case "Rapper":
                        Console.WriteLine("Cristal");
                        break;
                    default:
                        Console.WriteLine("Beer");
                        break;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Exception Error");
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }

                    Console.WriteLine("Task 1.5"); // ?
                    Console.WriteLine("Введите строку");
                    string str = Convert.ToString(Console.ReadLine());
                    bool English = str.Contains("English");
                    Console.WriteLine(English);

                    
                    Console.WriteLine("Task 2.1");
                    double sum = 0;
                    double num = 1;
                    for (int i = 0; i<8; i++)
                    {
                        sum += num;
                        num *= 1 / 3;
                    }
                    Console.WriteLine(sum);

            Console.WriteLine("Task2.2"); // Цикл не так составлен? Выводит 100 строк, а значение не меняется
            int N;
            double way = 0;
            double distance = 1;
            for (N = 1; N < 100; N++)
            {
                if (N % 2 == 0)
                {
                    way = way - (1 / N);
                    distance = distance + (1 / N);
                }
                if (N % 2 != 0) 
                {
                    distance += (1 / N);
                    way += (1 / N);
                }
                Console.WriteLine("После 100 этапа мужчина будет на расстоянии - {0}", distance);
                Console.WriteLine("Общий путь пройденный им равен {0}", way);
            }
            
            Console.WriteLine("Task 3.2");
            Console.WriteLine("Введите число");
             N = Convert.ToInt32(Console.ReadLine());
            int i = 0;
            while (i * i <= N)
            {
                i += 1;
            }
            Console.WriteLine("${i*i}");
























        }
    }
}
