using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    internal class Program
    {
        
        
            
        
        static void Task7()
        {


            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Выполение задачи 7 ....");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");

            



        }
        static void Task1()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Выполение задачи 1 ....");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");

            // Бабин
            // Написать метод, возвращающий минимальное из трёх чисел.
            Console.WriteLine("Сравнение трех чисел");
            Console.WriteLine("==================== ");

            Console.WriteLine("Введите первое число ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе число ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите третье число ");
            double c = double.Parse(Console.ReadLine());

            double maxNumber;

            if (a > b)
            {
                maxNumber = a;
            }
            else
            {
                maxNumber = b;
                if (b > c)
                {
                    maxNumber = b;
                }
                else
                {
                    maxNumber = c;
                    if (c > b)
                    {
                        maxNumber = c;
                    }
                }

            }

            Console.WriteLine("Большее число = " + maxNumber);
            Console.ReadLine();
            Console.Clear();
            

        }
        static void Task2()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Выполение задачи 2 ....");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");


            Console.WriteLine("Введите целое четное число ");
            int a = int.Parse(Console.ReadLine());
            int count = 0;
            while (a != 0)
            {
                count++;
                a = a / 10;
            }

            Console.WriteLine(count);
            Console.ReadLine();

        }
        static void Task3()
        {
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Выполение задачи 3 ....");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");


            int a;
            int s = 0;

            do
            {
                Console.WriteLine("Вводите любые положительные числа, как только введете 0, будет произведен подсчет нечетных чисел");
                a = int.Parse(Console.ReadLine());

                if (a % 2 == 1)
                {
                    s = s + a;

                }

            }


            while (a > 0);

            Console.WriteLine("Сумма всех нечетных чисел = " + s);
            Console.ReadLine();
        }

        static void Task4()
        {

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Выполение задачи 4 ....");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");

            string login = "root"; string password = "GeekBrains";
            string x, y;
            int a = 0;
            do
            {

                Console.Write("Введите логин: root\n ");
                x = Console.ReadLine();

                Console.Write("Введите пароль: GeekBrains\n ");
                y = Console.ReadLine();
                a++;
                if (a == 3) 
                {
                    Console.WriteLine("У вас закончились попытки");
                    break;

                }


            }
            while (x != "root" || y != "GeekBrains");
            {
               
               
                
                Console.WriteLine("Вы ввели верно!");
                
                Console.ReadLine();


            }

        }

        static void Task5()
        {

            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("Выполение задачи 5 ....");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");

           
            Console.WriteLine("Введите ваш вес ");
            string m = Console.ReadLine();
            int x = int.Parse(m);

            Console.WriteLine("Введите ваш рост ");
            string h = Console.ReadLine();
            double y = double.Parse(h);

            double IMT;
            IMT = x / (y * y);
            Console.WriteLine("Ваш индекс массы тела равен " + IMT);

            if (IMT < 16)

            {
                Console.WriteLine("Выраженный дефицит массы тела ");

            }
            else if (IMT > 16 & IMT < 18.5) 
            {
                Console.WriteLine("Недостаточная (дефицит) масса тела ");
            }

            else if (IMT > 18.5 & IMT < 25)
            {
                Console.WriteLine("Норма ");
            }
            else if (IMT > 25 & IMT < 30)
            {
                Console.WriteLine("Избыточная масса тела (предожирение) ");
            }
            else if (IMT > 30 & IMT < 35)
            {
                Console.WriteLine("Ожирение первой степени ");
            }
            else if (IMT > 35 & IMT < 40)
            {
                Console.WriteLine("Ожирение второй степени ");
            }
            else if (IMT > 40)
            {
                Console.WriteLine("Ожирение третьей степени (морбидное) ");
            }


            Console.ReadLine();
            Console.Clear();
            
           











        }
        static void Main(string[] args)
        {
           
            Console.WriteLine("Мои задачи");
            Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("1 - Задача 1");
            Console.WriteLine("2 - Задача 2");
            Console.WriteLine("3 - Задача 3");
            Console.WriteLine("4 - Задача 4");
            Console.WriteLine("5 - Задача 5");
            

            
            
            
            Console.WriteLine("Введите номер задания");
            int nubmer = int.Parse(Console.ReadLine());
            switch (nubmer) 
            {
                case 1:
                    Task1();
                    break;
                case 2:
                    Task2();
                    break;
                case 3:
                    Task3();
                    break;
                case 4:
                    Task4();
                    break;
                case 5:
                    Task5();
                    break;
               

            }

        }
        
        }
    }

