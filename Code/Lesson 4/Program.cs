using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            // ----- TASK 1 -----

            Console.WriteLine("Введите ваш вес (кг):");
            double weight = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш рост (м):");
            double height = double.Parse(Console.ReadLine());

            double bmi = weight / (height * height);
            Console.WriteLine($"Ваш ИМТ: {bmi:F2}"); // :F2 - форматирование до 2 знаков после запятой

            if (bmi < 18.5)
            {
                Console.WriteLine("Недостаточный вес.");
            }
            else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine("Нормальный вес.");
            }
            else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine("Избыточный вес.");
            }
            else
            {
                Console.WriteLine("Ожирение.");
            }

            // ----- TASK 2 -----

            Console.WriteLine("Введите первое число:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите операцию (+, -, *, /):");
            char operation = char.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            double b = double.Parse(Console.ReadLine());

            double result = 0;
            bool isOperationValid = true;

            switch (operation)
            {
                case '+':
                    result = a + b;
                    break;
                case '-':
                    result = a - b;
                    break;
                case '*':
                    result = a * b;
                    break;
                case '/':
                    // Важно: добавляем проверку деления на ноль
                    if (b != 0)
                        result = a / b;
                    else
                        Console.WriteLine("Ошибка: Деление на ноль!");
                    break;
                default:
                    isOperationValid = false;
                    Console.WriteLine("Ошибка: Неизвестная операция.");
                    break;
            }

            if (isOperationValid && operation != '/' || (operation == '/' && b != 0))
            {
                Console.WriteLine($"Результат: {result}");
            }

            Console.ReadKey();
        }
    }
}
