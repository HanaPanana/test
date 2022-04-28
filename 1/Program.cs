using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    internal class Program
    {
         static void Main(string[] args)



          {

          
              // Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес).
              // В результате вся информация выводится в одну строчку:

              // Бабин

              Console.WriteLine("Введите ваше имя ");
              string name = Console.ReadLine();
              Console.WriteLine("Введите вашу фамилию ");
              string soname = Console.ReadLine();

              Console.WriteLine("Введите ваш возраст ");
              string old = Console.ReadLine();

              Console.WriteLine("Введите ваш рост ");
              string height = Console.ReadLine();

              Console.WriteLine("Введите ваш вес ");
              string weight = Console.ReadLine();
              //используя склеивание
              Console.WriteLine(soname + " " + name + " возраст " + old + " рост " + height + " вес " + weight);
              //используя форматированный вывод
              Console.WriteLine("{0} {1} возраст {2} рост {3} вес {4}", soname, name, old, height, weight);
              //используя вывод со знаком $.
              Console.WriteLine($"{soname} {name} возраст {old} рост {height} вес {weight}");

              Console.ReadLine();
              Console.Clear();




              //Ввести вес и рост человека.
              //Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
              Console.WriteLine("Введите ваш вес ");
              string inputWeight = Console.ReadLine();
              int x = int.Parse(inputWeight);

              Console.WriteLine("Введите ваш рост ");
              string inputHeight = Console.ReadLine();
              double y = double.Parse(inputHeight);

              double IMT;
              IMT = x / (y*y);
              Console.WriteLine("Ваш индекс массы тела равен " + IMT);
              Console.ReadLine();
              Console.Clear();





              // 3. 
              Console.WriteLine("Введите значение x1 ");
              string inputX1 = Console.ReadLine();
              double x1 = double.Parse(inputX1);

              Console.WriteLine("Введите значение y1 ");
              string inputY1 = Console.ReadLine();
              double y1 = double.Parse(inputY1);

              Console.WriteLine("Введите значение x2 ");
              string inputX2 = Console.ReadLine();
              double x2 = double.Parse(inputX2);

              Console.WriteLine("Введите значение y2 ");
              string inputY2 = Console.ReadLine();
              double y2 = double.Parse(inputY2);

              double r;
              r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

              Console.WriteLine("Расстояние между точками с координатами равно " + "{0:F2}", r);
              Console.ReadLine();
              Console.Clear();


              //4
              Console.WriteLine("Введите значение первой переменной");
              string inputA = Console.ReadLine();
              int a = int.Parse(inputA);


             Console.WriteLine("Введите значение второй переменной");
              string inputB = Console.ReadLine();
              int b=int.Parse(inputB);

              int c = a;
              a = b;
              b = c;

              Console.WriteLine("Значение первой перемееной равно " + a);
              Console.ReadLine();
              Console.Clear();




            //5


            Console.SetCursorPosition(100,25);
            Console.WriteLine("Бабин Евгений, г.Ростов-на-Дону");
            Console.ReadLine();
        }
        
        }
    }



        


    
    

