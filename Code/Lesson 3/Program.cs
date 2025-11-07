using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- [TASK 1] ---

            // Демонстрация основных типов и арифметических операций
            Console.WriteLine("=== Калькулятор начинающего программиста ===");

            // 1. Целочисленные операции
            int a = 17;
            int b = 5;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b; // Целочисленное деление!
            int remainder = a % b; // Остаток от деления

            Console.WriteLine($"Целые числа: {a} и {b}");
            Console.WriteLine($"Сложение: {a} + {b} = {sum}");
            Console.WriteLine($"Вычитание: {a} - {b} = {difference}");
            Console.WriteLine($"Умножение: {a} * {b} = {product}");
            Console.WriteLine($"Целочисленное деление: {a} / {b} = {quotient}");
            Console.WriteLine($"Остаток от деления: {a} % {b} = {remainder}");

            Console.WriteLine(); // Пустая строка для читабельности

            // 2. Вещественные числа и важность типа операндов
            double x = 10.0;
            double y = 3.0;
            double doubleQuotient = x / y;

            Console.WriteLine($"Вещественные числа: {x} и {y}");
            Console.WriteLine($"Вещественное деление: {x} / {y} = {doubleQuotient}");

            // Классическая ошибка
            double mistake = 10 / 3; // Оба операнда - int, результат - int, потом присваивается double
            Console.WriteLine($"Ошибка (10 / 3) в double: {mistake}"); // Выведет 3, а не 3.333...

            // Правильный вариант
            double correct = 10.0 / 3; // Хотя бы один операнд - double
            Console.WriteLine($"Правильно (10.0 / 3): {correct}");

            // Использование суффиксов
            float floatValue = 9.81f;
            decimal money = 100.5m;
            Console.WriteLine($"Ускорение свободного падения: {floatValue}");
            Console.WriteLine($"Сумма на счету: {money}р");

            // --- [TASK 2] ---

            Console.WriteLine("\n=== Логика и сравнения ===");

            int age = 17;
            double score = 4.75;
            bool isStudent = true;

            // Операции сравнения
            bool isAdult = age >= 18;
            bool isExcellentStudent = score >= 4.5;
            bool canGetDiscount = isStudent && isExcellentStudent; // Логическое И
            bool canEnterClub = isAdult || (age >= 16 && age < 18); // Логическое ИЛИ + комбинация условий

            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Балл: {score}");
            Console.WriteLine($"Совершеннолетний: {isAdult}");
            Console.WriteLine($"Отличник: {isExcellentStudent}");
            Console.WriteLine($"Может получить скидку (студент И отличник): {canGetDiscount}");
            Console.WriteLine($"Может войти в клуб (взрослый ИЛИ 16+ с ограничениями): {canEnterClub}");

            // Тернарный оператор
            char status = isAdult ? 'Y' : 'N';
            Console.WriteLine($"Статус: {status}");

            // Демонстрация инкремента
            int counter = 5;
            Console.WriteLine($"\nНачальное значение счётчика: {counter}");
            Console.WriteLine($"Постфиксный инкремент (counter++): {counter++}"); // Сначала вернет 5, потом увеличит до 6
            Console.WriteLine($"Значение после постфиксного инкремента: {counter}");
            Console.WriteLine($"Префиксный инкремент (++counter): {++counter}"); // Сначала увеличит до 7, потом вернет 7

            // --- [TASK 3] ---

            Console.WriteLine("\n=== Символы и неявная типизация ===");

            // Символьный тип char
            char firstLetter = 'A';
            char newLine = '\n';
            char heart = '\u0030'; // Символ 0 в Unicode

            Console.WriteLine($"Первая буква алфавита: {firstLetter}");
            Console.WriteLine($"Символ 0: {heart}");
            Console.WriteLine($"А вот это будет на новой строке:{newLine}<- Смотрите, новая строка!");

            // Неявная типизация var
            var implicitInteger = 42; // Компилятор понимает, что это int
            var implicitString = "Hello, World!"; // Компилятор понимает, что это string
            var implicitDouble = 3.14; // Компилятор понимает, что это double
            var implicitChar = 'X'; // Компилятор понимает, что это char

            Console.WriteLine($"\nНеявная типизация var:");
            Console.WriteLine($"implicitInteger имеет тип: {implicitInteger.GetType()}, значение: {implicitInteger}");
            Console.WriteLine($"implicitString имеет тип: {implicitString.GetType()}, значение: {implicitString}");
            Console.WriteLine($"implicitDouble имеет тип: {implicitDouble.GetType()}, значение: {implicitDouble}");
            Console.WriteLine($"implicitChar имеет тип: {implicitChar.GetType()}, значение: {implicitChar}");

            // Следующая строка вызовет ошибку КОМПИЛЯЦИИ, раскомментируйте, чтобы увидеть:
            // var error; // Ошибка CS0818: Неявно типизированные переменные должны быть инициализированы

            // --- [TASK 4] ---

            Console.WriteLine("\n=== Мини-практикум: Ввод данных ===");

            // Важно: ReadLine() возвращает string, поэтому нужно преобразование.
            Console.Write("Введите целое число: ");
            string input = Console.ReadLine(); // Считываем строку
            int number = int.Parse(input); // Парсим строку в число int

            Console.Write("Введите ваше имя: ");
            var name = Console.ReadLine(); // Используем var, т.к. компилятор знает, что это string

            Console.Write("Вы студент? (true/false): ");
            bool isUserStudent = bool.Parse(Console.ReadLine());

            // Используем все введенные данные
            Console.WriteLine($"\nВас зовут {name}, вы ввели число {number}. Статус студента: {isUserStudent}");

            // Простые вычисления на основе ввода
            int futureAge = number + 10;
            Console.WriteLine($"Через 10 лет вам будет: {futureAge}");

            Console.ReadKey();
        }
    }
}
