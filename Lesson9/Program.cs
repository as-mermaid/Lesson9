using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вас приветствует калькулятор!");
            try
            {
                Console.Write("Введите целое число Х=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число Y=");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите код операции \n1 - сложение \n2 - вычетание \n3 - изведение \n4 - частное");
                int operation = Convert.ToInt32(Console.ReadLine());

                switch (operation)
                {
                    case 1:
                        Console.WriteLine(x + y);
                        break;
                    case 2:
                        Console.WriteLine(x - y);
                        break;
                    case 3:
                        Console.WriteLine(x * y);
                        break;
                    case 4:
                        Console.WriteLine(x / y);
                        break;
                    default:
                        Console.WriteLine("Нет операции с указанным номером");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.Write("Ошибка! ");
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
