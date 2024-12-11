using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 0, m = 0;

        
        while (true)
        {
            Console.WriteLine("Введите кол-во строк (n): ");
            if (int.TryParse(Console.ReadLine(), out n) && n > 0)
            {
                break; // Ввод корректен, выходим из цикла
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное значение.");
            }
        }

        
        while (true)
        {
            Console.Write("Введите кол-во столбцов (m): ");
            if (int.TryParse(Console.ReadLine(), out m) && m > 0)
            {
                break; // Ввод корректен, выходим из цикла
            }
            else
            {
                Console.WriteLine("Ошибка: введите корректное значение.");
            }
        }

        double[,] matrix = new double[n, m];
        int positiveCount = CountPositiveElements(n, m, matrix);
        Console.WriteLine($"Количество положительных элементов в матрице: {positiveCount}");

        // Вывод матрицы
        Console.WriteLine("Матрица:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write($"{matrix[i, j]} "); // Форматируем вывод без знаков после запятой
            }
            Console.WriteLine();
        }
    }

    static int CountPositiveElements(int n, int m, double[,] matrix)
    {
        Random random = new Random();
        int count = 0;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                // Генерируем случайное число от -10 до 10
                double element = random.Next(-10, 11); 
                matrix[i, j] = element; // Сохраняем элемент в матрице
                if (element > 0)
                {
                    count++;
                }
            }
        }
        return count;
    }
}
