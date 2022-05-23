using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork5
{
    public static class Message
    {
        private static string[] separators = { ",", ".", "!", "?", ";", ":", " ", "-" };

        public static int FindMaxLengthWord { get; private set; }

        

        public static void ChekSms(string sms)
        {

            //Вывести только те слова сообщения, которые содержат не более n букв.
            Console.WriteLine("Введите количество символов в слове:");
            int n = int.Parse(Console.ReadLine());

            string[] words = sms.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)

                if (word.Length < n)
                   
                    Console.WriteLine($"Слова сообщения, которые содержат не более {n} букв: {word} ");

            //Удалить из сообщения все слова, которые заканчиваются на заданный символ.
            Console.WriteLine("Введите букву: ");
            string a = Console.ReadLine();
            for (int i = 0; i < words.Length; i++)
                
                if (words[i].EndsWith(a))
                {
                    Console.WriteLine("****************\n");
                    Console.WriteLine($"Слова которые заканчиваются на {a}: {words[i]}");
                    Console.WriteLine("****************\n");
                }

            // Найти самое длинное слово сообщения.
            int max = 0;
            string maxWord = "";

            foreach (string x in words) 
            {
                if (x.Length > max)

                        max = x.Length;
                        maxWord = x;
            }

            Console.WriteLine("****************\n");
            Console.WriteLine("Самое длиное слово в строке: {0}", maxWord);
            Console.WriteLine("****************\n");

            
            
            StringBuilder result = new StringBuilder();
            int s = maxWord.Length;
            foreach (string f in words)
            {
                if (f.Length == s)
                {
                    result.Append(f.ToLower() + " ");
                }
            }


            Console.WriteLine("\nСформированная строка StringBuilder из самых длинных слов сообщения: \n" + result);



            Console.ReadLine();






        }

        

        internal class Program
        {



            private static bool CheckLogin(string login)
            {

                // Проверим логин на соответствие корректной длине
                if (login.Length < 2 || login.Length > 10)

                    return false;

                // Первый символ должен быть исключительно символом алфавита, заранее приведу символ к нижнему
                // регистру, для последующего удобства проверки, теперь для меня символ алфавита
                // всегда будет относиться к категории UnicodeCategory.LowercaseLetter
                if (char.GetUnicodeCategory(char.ToLower(login[0])) != UnicodeCategory.LowercaseLetter)
                    return false;


                // Проверим логин посимвольно

                foreach (char c in login)
                {
                    switch (char.GetUnicodeCategory(char.ToLower(c)))
                    {
                        case UnicodeCategory.DecimalDigitNumber:
                        case UnicodeCategory.LowercaseLetter:
                            break;
                        default:
                            // Если символ соответствует категории отличной от UnicodeCategory.DecimalDigitNumber и
                            // UnicodeCategory.LowercaseLetter немедленно завершаем работу метода
                            return false;

                    }
                }

                // Мы прошли все проверки, теперь, совершенно точно можно сказать, наш логин вполне корректный
                return true;


            }

            static void Task1()
            {
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("Выполение задачи 1 ....");
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");

                Console.WriteLine("Введите логин: ");
                string login = Console.ReadLine();
                Program.CheckLogin(login);



            }

            static void Task2()
            {
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("Выполение задачи 2 ....");
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");



                Console.WriteLine("Введите предложение: ");
                string sms = Console.ReadLine();

                Message.ChekSms(sms);


                Console.ReadKey();




            }
            static void Main(string[] args)
            {

                Console.WriteLine("Мои задачи");
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
                Console.WriteLine("1 - Задача 1");
                Console.WriteLine("2 - Задача 2");



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



                Console.ReadLine();



            }
        }
    }
}
