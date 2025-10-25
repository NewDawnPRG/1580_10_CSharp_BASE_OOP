using System;
using System.Threading;

class Program
{
    static void Main()
    {
        // === Beep ===
        Console.WriteLine("1. Beep() — звуковой сигнал по умолчанию");
        Console.Beep(); // Короткий системный звук
        Thread.Sleep(500);

        Console.WriteLine("2. Beep(800, 3000) — звук 800 Гц, 3000 мс");
        Console.Beep(800, 3000);
        Thread.Sleep(500);

        // === Clear ===
        Console.WriteLine("3. Clear() — очистка консоли через 2 секунды...");
        Thread.Sleep(2000);
        Console.Clear();


        // === Цвета и ResetColor ===
        Console.ForegroundColor = ConsoleColor.Green;
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.WriteLine("4. Цветной текст (зелёный на синем)");
        Console.ResetColor();
        Console.WriteLine("5. ResetColor() — цвета сброшены к стандартным");


        // === Read, ReadKey, ReadLine ===
        Console.WriteLine("6. Read() — нажмите любую клавишу (символ будет считан):");
        int charCode = Console.Read();
        Console.WriteLine($"Вы ввели символ с кодом: {charCode} ('{(char)charCode}')");

        Console.WriteLine("\n7. ReadKey() — нажмите любую клавишу:");
        ConsoleKeyInfo key = Console.ReadKey();
        Console.WriteLine($"\nВы нажали: {key.Key}");

        Console.WriteLine("\n8. ReadLine() — введите строку и нажмите Enter:");
        string input = Console.ReadLine();
        Console.WriteLine($"Вы ввели: \"{input}\"");

        // === Write и WriteLine ===
        Console.WriteLine("\n9. Write и WriteLine — сравнение:");
        Console.Write("Это Write — ");
        Console.Write("всё в одной строке.\n");
        Console.WriteLine("А это WriteLine —");
        Console.WriteLine("каждый вызов — с новой строки.");

        // Завершение
        Console.WriteLine("\nДемонстрация завершена. Нажмите любую клавишу для выхода.");
        Console.ReadKey();
    }
}