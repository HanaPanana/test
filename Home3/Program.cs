using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home3
{
    class MyComplex
    {
        private double re;
        private double im;

        public MyComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }

        public MyComplex()
        {

        }

        public MyComplex Plus(MyComplex x)
        {
            MyComplex y = new MyComplex(re + x.re, im + x.im);
            //y.re = re + x.re;
            //y.im = im + x.im;
            return y;

        }

        public string ToString()
        {
            return re + "+" + im + "i";
        }

        public MyComplex Sub(MyComplex x)
        {
            MyComplex y = new MyComplex(re - x.re, im - x.im);
            //y.re = re - x.re;
            //y.im = im - x.im;
            return y;
        }

        public MyComplex Multi(MyComplex x)
        {
            MyComplex y = new MyComplex(x.im + im * x.re, x.re - im * x.im);
            //y.im = re * x.im + im * x.re;
            //y.re = re * x.re - im * x.im;
            return y;
        }
        internal class Program
        {

            static void Task1()
            {
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("Выполение задачи 1 ....");
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");

                MyComplex complex1 = new MyComplex(1, 2);
                //complex1.re = 1;
                //complex1.im = 2;

                MyComplex complex2 = new MyComplex(3, 4);
                //complex2.re = 3;
                //complex2.im = 4;

                MyComplex complex3 = complex1.Plus(complex2);
                Console.WriteLine(complex3.ToString());
                complex3 = complex1.Sub(complex2);

                MyComplex complex4 = complex1.Multi(complex2);


                Console.WriteLine(complex3.ToString());
                Console.WriteLine(complex4.ToString());



                Console.ReadLine();
                Console.Clear();




            }



            static void Task2()
            {
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("Выполение задачи 2 ....");
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");

                int s = 0;
                int inputX;
                bool pro = true;

                do
                {
                   
                    Console.WriteLine("Введите числа, число 0 завершит операцию и посчитает сумму всех нечётных положительных чисел");

                    if (int.TryParse(Console.ReadLine(), out inputX))
                    
                    {
                        if (inputX == 0) 
                        {
                            pro = false;
                        }
                        
                        s = s + inputX;
                        
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не коректное число");
                    }
                    
                }

                while (pro);
               
                {
                    Console.WriteLine("Сумма всех нечетных чисел = " + s);
                    Console.ReadLine();
                }


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



                    }
                }
            }
        }
    }


        
    

