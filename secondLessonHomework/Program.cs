using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondLessonHomework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            taskSix();
        }
        /// <summary>
        /// счетчик символов и пробелов до точки в строке
        /// </summary>
        static void taskOne()
        {
            System.Console.WriteLine("введите текст с точкой в конце");
            string userText = Console.ReadLine();
            int i = 0;
            int charSum = 0;
            int spaceSum = 0;
            while(userText[i] != '.') 
            { 
                charSum++;
                if (userText[i] == Convert.ToChar(' '))
                {
                    spaceSum++;
                }
                i++;
            }
            Console.WriteLine("Общее количество символов до точки = {0}",charSum);
            Console.WriteLine("Количество пробелов до точки = {0}",spaceSum);
        }
        /// <summary>
        /// Метод определяющий является ли билет счастливым по сумме первых и последних трех элементов
        /// </summary>
        static void taskTwo()
        {
            Random random= new Random();
            string ticket = Convert.ToString(random.Next(100000, 1000000)/*777777*/);
            int firstHalf = 0;int secondHalf = 0;
            Console.WriteLine(ticket);
            for (int i = 1; i < ticket.Length / 2; i++)
            {
                firstHalf += Convert.ToInt32(ticket[i]);
            }
            // честно до конца не понял почему но если не указать -1 в длине то выдает ошибку
            for (int j = ticket.Length - 1; j > ticket.Length / 2; j--)
            {
                secondHalf += Convert.ToInt32(ticket[j]);
            }
            //Console.WriteLine(firstHalf); Console.WriteLine(secondHalf);
            
            if (firstHalf == secondHalf)
            {
                Console.WriteLine("СЧАСТЛИВЫЙ БИЛЕТ!");
            }
            else
            {
                Console.WriteLine("ПОВЕЗЕТ В СЛЕДУЮЩИЙ РАЗ");
            }
        }
        /// <summary>
        /// смена регистра в введенной строке
        /// </summary>
        static void taskThree()
        {
            string str = Console.ReadLine();
            string newStr = "";
            //Console.WriteLine(str);
            for (int i = 0; i < str.Length; i++)
            {
                if (char.IsUpper(str[i]))
                {
                    newStr += char.ToLower(str[i]);
                }
                if (char.IsLower(str[i]))
                {
                    newStr += char.ToUpper(str[i]);
                }
            }
            str = newStr;
            Console.WriteLine(str);
        }
        /// <summary>
        /// вывод чисел из промежутка каждый раз соответсвующий их значениям
        /// </summary>
        static void taskFour()
        {
            //указал B + 1 ибо в while здесь не получается использовать <=
            int A = 2;int B = 8;int temp = 0;
            for (int i = A; i < B + 1; i++)
            {
                while (temp < i)
                {
                    if (temp!= i)
                    {
                        Console.Write(i + " ");
                        temp++;
                        continue;
                    }
                }
                temp = 0;
                //две Console.WriteLine для отступа между строками
                Console.WriteLine();
                Console.WriteLine();
            }
        }
        /// <summary>
        /// метод который выводит указанное число справа налево
        /// </summary>
        static void taskFive()
        {
            int num = Convert.ToInt32(Console.ReadLine());
            string newNum = Convert.ToString(num);
            //та же проблема что и во втором задании если не указать Length - 1 то выходит ошибка
            for (int i = newNum.Length - 1; i >= 0; i--)
            {
                Console.Write(newNum[i]);
            }
            Console.WriteLine();
        }
        /// <summary>
        /// Вывод предыдущего и следующего дня по дате
        /// </summary>
        static void taskSix()
        {
            //Console.WriteLine("Введите три числа");
            //Console.Write("Ввод первого числа: ");
            //int numFirst = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ввод второго числа: ");
            //int numSecond = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Ввод третьего числа: ");
            //int numThird = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("{0}  {1}  {2}",numFirst,numSecond,numThird);
            int year = Convert.ToInt32(Console.ReadLine());
            int month = Convert.ToInt32(Console.ReadLine());
            int day = Convert.ToInt32(Console.ReadLine());

            DateTime today = new DateTime(year,month,day);
            Console.WriteLine("текущий день - {0}", today);
            Console.WriteLine("следующий день - {0}", today.AddDays(1));
            Console.WriteLine("прошлый день - {0}",today.AddDays(-1));

        }
        /// <summary>
        /// Вывод трех чисел друг под другом..?
        /// </summary>
        static void taskSeven()
        {
            Console.WriteLine(5);
            Console.WriteLine(10);
            Console.WriteLine(21);
        }
        /// <summary>
        /// переводит расстояние в сантиметрах в метры
        /// </summary>
        static void taskEight()
        {
            Console.WriteLine("Введите расстояние в сантиметрах");
            int centimeters = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("В {0} сантиметрах есть  - {1} полных метров", centimeters, centimeters / 100);
        }
        /// <summary>
        /// считает количество недель за определенное время
        /// </summary>
        static void taskNine()
        {
            Console.WriteLine("за 234 дня прошло - {0} полных недель",234 / 7);
        }
        /// <summary>
        /// операции с цифрами двузначного числа
        /// </summary>
        static void taskTen()
        {
            Console.WriteLine("введите двузначное число");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("число десятков в числе {0} - {1}",num,num/10);
            Console.WriteLine("число единиц в числе {0} - {1}", num, num % 10);
            Console.WriteLine("сумма цифр в числе {0} - {1}", num, num / 10 + num % 10);
            Console.WriteLine("произведение цифр в числе {0} - {1}", num, (num / 10) * (num % 10));
        }
    }
}
