using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Створення масиву з 20 випадкових чисел (додатніх і від’ємних)
        int[] numbers = { 12, -5, 3, -8, 9, -2, 7, -11, 4, -15, 10, -3, 6, -4, 8, -7, 1, -6, 14, -9 };

        // Запит LINQ для вибору всіх додатних чисел
        var positiveNumbers = numbers.Where(n => n > 0).ToArray();

        // Запит LINQ для вибору всіх від’ємних чисел
        var negativeNumbers = numbers.Where(n => n < 0).ToArray();

        // Обчислення кількості додатних чисел
        int positiveCount = positiveNumbers.Count();

        // Виведення результатів
        Console.WriteLine("Додатні числа:");
        foreach (var num in positiveNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine("\nВід’ємні числа:");
        foreach (var num in negativeNumbers)
        {
            Console.WriteLine(num);
        }

        Console.WriteLine($"\nКількість додатних чисел: {positiveCount}");
    }
}
