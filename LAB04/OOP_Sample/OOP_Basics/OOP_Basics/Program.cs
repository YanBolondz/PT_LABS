using System;

namespace OOP_Basics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Тестирование класса Time ===\n");

            try
            {
                // Тест 1: Создание объектов с использованием конструкторов
                Console.WriteLine("1. Создание объектов Time:");

                Time time1 = new Time(14, 30, 45);


                Time t6 = new Time();
                Console.WriteLine($"Время 1: {time1}");

                Time time2 = new Time(23, 45, 15);
                Console.WriteLine($"Время 2: {time2}");

                Time time3 = new Time(); // Конструктор по умолчанию
                Console.WriteLine($"Время 3 (по умолчанию): {time3}\n");

                // Тест 2: Проверка свойств чтения/записи
                Console.WriteLine("2. Проверка свойств:");
                time1.Hour = 10;
                time1.Minutes = 25;
                time1.Seconds = 50;
                Console.WriteLine($"Измененное время 1: {time1}");

                // Тест 3: Метод AddMinutes
                Console.WriteLine("\n3. Тестирование AddMinutes:");

                Console.WriteLine($"Исходное время: {time1}");

                Time newTime1 = time1.AddMinutes(30);
                Console.WriteLine($"+30 минут: {newTime1}");

                Time newTime2 = time1.AddMinutes(90);
                Console.WriteLine($"+90 минут: {newTime2}");

                Time newTime3 = time1.AddMinutes(-45);
                Console.WriteLine($"-45 минут: {newTime3}");

                Time newTime4 = time1.AddMinutes(24 * 60 + 15); // +1 сутки 15 минут
                Console.WriteLine($"+1 сутки 15 минут: {newTime4}");

                // Тест 4: Метод PrintTime
                Console.WriteLine("\n4. Использование PrintTime():");
                Console.Write("Время 1: ");
                time1.PrintTime();

                Console.Write("Время 2: ");
                time2.PrintTime();

                // Тест 5: Проверка валидации (должны генерироваться исключения)
                Console.WriteLine("\n5. Проверка валидации (исключения):");

                Console.WriteLine("Попытка создать время с hour=25:");
                try
                {
                    Time invalidTime1 = new Time(25, 0, 0);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }

                Console.WriteLine("\nПопытка установить minutes=70:");
                try
                {
                    time1.Minutes = 70;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}");
                }

                Console.WriteLine("\nПопытка установить seconds=-5:");
                try
                {
                    time1.Seconds = -5;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"Ошибка: {ex.Message}\n");
                }

                // Тест 6: Граничные случаи
                Console.WriteLine("6. Граничные случаи:");

                Time midnight = new Time(0, 0, 0);
                Console.WriteLine($"Полночь: {midnight}");
                Console.WriteLine($"Полночь + 1 минута: {midnight.AddMinutes(1)}");
                Console.WriteLine($"Полночь - 1 минута: {midnight.AddMinutes(-1)}");

                Time almostMidnight = new Time(23, 59, 59);
                Console.WriteLine($"Почти полночь: {almostMidnight}");
                Console.WriteLine($"Почти полночь + 1 минута: {almostMidnight.AddMinutes(1)}");

                // Тест 7: Метод ToString
                Console.WriteLine("\n7. Использование ToString():");
                Console.WriteLine($"time1.ToString() = {time1.ToString()}");
                Console.WriteLine($"time2 в строковом контексте: {time2}");

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Неожиданная ошибка: {ex.Message}");
            }

            Console.WriteLine("\n=== Тестирование завершено ===");
            Console.WriteLine("Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}