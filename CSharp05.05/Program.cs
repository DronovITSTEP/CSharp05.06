using GenTextProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp05._06
{
    internal class Program
    {
        /*
        Пользователь вводит в строку с клавиатуры математическое выражение.
        Например, 3*2*1*4. Программа должна
        посчитать результат введенного выражения. 
        В строке могут быть только целые числа и оператор *. Для обработки
        ошибок ввода используйте механизм исключений.
        */

        /*
        Создайте игру «Угадай число». 
        Пользователь загадывает число в указанном диапазоне, 
        компьютер угадывает.
        Используйте механизмы пространств имён*/

        
        static void Main(string[] args)
        {
            // 5*7*6*2*7 Ok
            // 25*4*0*7 Ok
            // 1+8*8+9 Error
            // 5 * 8*7 *9 Ok
            // г*8 Error
            // 5 Ok
            // * Error
            /*try
            {
                string str =Console.ReadLine();
                string[] strArr = str.Split("*".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
                int res = 1;
                foreach (string str2 in strArr)
                {
                    checked
                    {
                        res *= int.Parse(str2);
                    }
                }
                Console.WriteLine(res);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }*/

            /*int min = 0;
            int max = 100;
            int numComp = (min + max) / 2;
            int numPlayer = 57;
            while (numPlayer != numComp)
            {
                Console.WriteLine("Компьютер -> " + numComp);
                Console.WriteLine("больше (<) или меньше(>) ? -> ");
                string c = ReadLine();
                if (c == "<")
                {
                    min = numComp;
                }
                else if (c == ">")
                {
                    max = numComp;
                }
                else
                {
                    Console.WriteLine("неверный ввод");
                    continue;
                }
                numComp = (min + max) / 2;
            }
            if (numComp == numPlayer)
            {
                WriteLine("Компютер угадал. Число -> " + numComp);
            }*/

            GenerationText generationText = new GenerationText(3, 5, 5);
            WriteLine(generationText.Generation());

            Console.ReadLine();
        }
    }
}
