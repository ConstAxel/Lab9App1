using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab9App1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Смоделируйте работу простого калькулятора. Программа должна запрашивать 2 числа, а затем – код операции(например, 1 – сложение, 2 – вычитание, 3 – произведение, 4 – частное).
            //    После этого на консоль выводится ответ. Используйте обработку исключений для защиты от ввода некорректных данных.
            Console.WriteLine("Привет я калькулятор");
            try
            {
                string A = "";
                string B = "";
                Console.Write("Введите целое число А=");
                A = Console.ReadLine();
                double cleanA = 0;
                while (!double.TryParse(A, out cleanA))
                {
                    Console.WriteLine("Вы ввели неверно, повторите ввод целого числа ");
                    Console.Write("Введите целое число А=");
                    A = Console.ReadLine();
                }
                Console.Write("Введите целое число Б=");
                B = Console.ReadLine();
                double cleanB = 0;
                while (!double.TryParse(B, out cleanB))
                {
                    Console.WriteLine("Вы ввели неверно, повторите ввод целого числа ");
                    Console.Write("Введите целое число B=");
                    B = Console.ReadLine();
                }
                Console.WriteLine("Возможные операции:");
                Console.WriteLine("\t1 - сложение;\n\t2 - вычитание;\n\t3 - умножение;\n\t4 - частное;");
                Console.Write("Введите код операции:");
                int option = Convert.ToInt32(Console.ReadLine());
                while (option < 1 || option > 4)
                {
                    Console.WriteLine("Код операции введен неправильно. Введите индекс операции от 1 до 4");
                    Console.Write("Введите код операции:");
                    option = int.Parse(Console.ReadLine());
                }

                switch (option)
                {
                    case 1:
                        {
                            Console.Write("Сумма чисел А+Б=");
                            Console.WriteLine($"{cleanA + cleanB:f2}");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Разность числе А-Б=");
                            Console.WriteLine($"{cleanA - cleanB:f2}");
                            break;
                        }
                    case 3:
                        {
                            Console.Write("Произведение чисел А*Б=");
                            Console.WriteLine($"{cleanA * cleanB:f2}");
                            break;
                        }
                    case 4:
                        {
                            if (cleanA != 0 && cleanB == 0)
                            {
                                Console.Write("Деление на 0");
                                break;
                            }
                            else if (cleanA == 0 && cleanB == 0)
                            {
                                Console.Write("Деление 0 на 0");
                            }
                            else
                            {
                                Console.Write("Частное чисел А/Б=");
                                Console.WriteLine($"{cleanA / cleanB:f2}");
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка!" + ex.Message);
            }
            
            
            Console.ReadKey();
        }
    }
}
