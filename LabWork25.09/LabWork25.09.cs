using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork25._09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4.1");
            Console.WriteLine("Введите номер дня в году");
            int Day = Convert.ToInt32(Console.ReadLine());
            if (Day>0 && Day<=31)
            {
                Console.WriteLine($"{Day} Января");
            }
            else if (Day <= 59)
            {
                Console.WriteLine($"{Day - 31} февраля");
            }
            else if (Day <= 90)
            {
                Console.WriteLine($"{Day - 59} марта ");
            }
            else if (Day <= 120)
            {
                Console.WriteLine($"{Day - 90} апреля ");
            }
            else if (Day <= 151)
            {
                Console.WriteLine($"{Day - 120} мая ");
            }
            else if (Day <= 181)
            {
                Console.WriteLine($"{Day - 151} июня ");
            }
            else if (Day <= 212)
            {
                Console.WriteLine($"{Day - 181} июля ");
            }
            else if (Day <= 243)
            {
                Console.WriteLine($"{Day - 212} августа ");
            }
            else if (Day <= 273)
            {
                Console.WriteLine($"{Day - 243} сентября ");
            }
            else if (Day <= 304)
            {
                Console.WriteLine($"{Day - 273} октября ");
            }
            else if (Day <= 334)
            {
                Console.WriteLine($"{Day - 304} ноября");
            }
            else if (Day <= 365)
            {
                Console.WriteLine($"{Day - 334} декабря ");
            }
            else
            {
                Console.WriteLine("Такого дня в году нет");
            }

            Console.WriteLine("Задание 4.2"); // Не ловит ошибку с отриөателҗными значениями(?)
            try
            {
                Console.WriteLine("Введите число от 1 до 365");
                Day = Convert.ToInt32(Console.ReadLine());
                if (Day > 0 && Day <= 31)
                {
                    Console.WriteLine($"{Day} Января");
                }
                else if (Day <= 59)
                {
                    Console.WriteLine($"{Day - 31} февраля");
                }
                else if (Day <= 90)
                {
                    Console.WriteLine($"{Day - 59} марта ");
                }
                else if (Day <= 120)
                {
                    Console.WriteLine($"{Day - 90} апреля ");
                }
                else if (Day <= 151)
                {
                    Console.WriteLine($"{Day - 120} мая ");
                }
                else if (Day <= 181)
                {
                    Console.WriteLine($"{Day - 151} июня ");
                }
                else if (Day <= 212)
                {
                    Console.WriteLine($"{Day - 181} июля ");
                }
                else if (Day <= 243)
                {
                    Console.WriteLine($"{Day - 212} августа ");
                }
                else if (Day <= 273)
                {
                    Console.WriteLine($"{Day - 243} сентября ");
                }
                else if (Day <= 304)
                {
                    Console.WriteLine($"{Day - 273} октября ");
                }
                else if (Day <= 334)
                {
                    Console.WriteLine($"{Day - 304} ноября");
                }
                else if (Day <= 365)
                {
                    Console.WriteLine($"{Day - 334} декабря ");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("ArgumentOutOfRangeException error");
            }
            finally
            {
                Console.WriteLine("Программа завершена");
            }

            Console.WriteLine("Дом.Задание 4.1");
            Console.WriteLine("Введите год");
            int Year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите номер дня в году");
            Day = Convert.ToInt32(Console.ReadLine());
            if ((Year % 4 == 0 && Year % 400 == 0) || (Year % 100 != 0))
            {
                if (Day > 0 && Day <= 31)
                {
                    Console.WriteLine($"{Day} Января");
                }
                else if (Day <= 60)
                {
                    Console.WriteLine($"{Day - 31} февраля");
                }
                else if (Day <= 91)
                {
                    Console.WriteLine($"{Day - 60} марта ");
                }
                else if (Day <= 121)
                {
                    Console.WriteLine($"{Day - 91} апреля ");
                }
                else if (Day <= 152)
                {
                    Console.WriteLine($"{Day - 121} мая ");
                }
                else if (Day <= 182)
                {
                    Console.WriteLine($"{Day - 152} июня ");
                }
                else if (Day <= 213)
                {
                    Console.WriteLine($"{Day - 182} июля ");
                }
                else if (Day <= 244)
                {
                    Console.WriteLine($"{Day - 213} августа ");
                }
                else if (Day <= 274)
                {
                    Console.WriteLine($"{Day - 244} сентября ");
                }
                else if (Day <= 305)
                {
                    Console.WriteLine($"{Day - 274} октября ");
                }
                else if (Day <= 335)
                {
                    Console.WriteLine($"{Day - 304} ноября");
                }
                else if (Day <= 365)
                {
                    Console.WriteLine($"{Day - 335} декабря ");
                }
            }
            else
            {
                if (Day > 0 && Day <= 31)
                {
                    Console.WriteLine($"{Day} Января");
                }
                else if (Day <= 59)
                {
                    Console.WriteLine($"{Day - 31} февраля");
                }
                else if (Day <= 90)
                {
                    Console.WriteLine($"{Day - 59} марта ");
                }
                else if (Day <= 120)
                {
                    Console.WriteLine($"{Day - 90} апреля ");
                }
                else if (Day <= 151)
                {
                    Console.WriteLine($"{Day - 120} мая ");
                }
                else if (Day <= 181)
                {
                    Console.WriteLine($"{Day - 151} июня ");
                }
                else if (Day <= 212)
                {
                    Console.WriteLine($"{Day - 181} июля ");
                }
                else if (Day <= 243)
                {
                    Console.WriteLine($"{Day - 212} августа ");
                }
                else if (Day <= 273)
                {
                    Console.WriteLine($"{Day - 243} сентября ");
                }
                else if (Day <= 304)
                {
                    Console.WriteLine($"{Day - 273} октября ");
                }
                else if (Day <= 334)
                {
                    Console.WriteLine($"{Day - 304} ноября");
                }
                else if (Day <= 365)
                {
                    Console.WriteLine($"{Day - 334} декабря ");
                }
                else
                {
                    Console.WriteLine("Ошибка. Неверно введен год или номер дня в году");
                }
            }













        }






        }
    }

