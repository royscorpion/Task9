using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Простой калькулятор с обработкой исключений для защиты от ввода некорректных значений
            Console.WriteLine("Вас приветствует калькулятор!");
            
            //Ввод двух чисел
            Console.Write("Введите целое число: A=");
            InputNumber(out int a);
            Console.Write("Введите целое число: B=");
            InputNumber(out int b);
            
            //Выбор операции
            bool x;
            do
            {
                InputOperation(out int c);
                switch (c)
                {
                    case 1:
                        {
                            Console.WriteLine("Результат: {1} + {2} = {0}", a + b, a, b);
                            x = false;
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Результат: {1} - {2} = {0}", a - b, a, b);
                            x = false;
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Результат: {1} * {2} = {0}", a * b, a, b);
                            x = false;
                            break;
                        }
                    case 4:
                        {
                            try
                            {
                                Console.WriteLine("Результат: {1} / {2} = {0:f2}", (float)a / b, a, b);
                                x = false;
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("Ошибка! {0}", ex.Message);
                                x = true;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Нет операции с указанным номером\n");
                            x = true;
                            break;
                        }
                }
            } while (x);
            Console.ReadKey();
        }

        //Метод ввода числа с обработкой исключений
        static void InputNumber(out int number)
        {
            number = 0;
            bool x;
            do
            {
                try
                {
                    number = Convert.ToInt32(Console.ReadLine());
                    x = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}\nПопробуйте еще раз\n", ex.Message);
                    Console.Write("Введите целое число: ");
                    x = true;
                }
            } while (x);
        }

        //Метод ввода кода операции с обработкой исключений
        static void InputOperation(out int code)
        {
            code = 0;
            bool x;
            do
            {
                Console.Write("Введите код операции:\n{0}\n{1}\n{2}\n{3}\nВаш выбор: ", "1 - сложение", "2 - вычитание", "3 - произведение", "4 - частное");
                try
                {
                    code = Convert.ToInt32(Console.ReadLine());
                    x = false;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ошибка! {0}\nПопробуйте еще раз\n", ex.Message);
                    x = true;
                }
            } while (x);

        }
    }
}
