
using System;

class Program
{
    private static string cout;

    static void Main(string[] args)
    {
        Task8();
        Task9();
        Task10();
        Task11();
        Task12();
        Task13();
        Task14();
    }

    private static void Task8()
    {
        Console.Write("Enter a positive number:");
        string number = Console.ReadLine();
        int result = Int32.Parse(number);
        int sum = 0;
        for (int i = 1; i < result; i++)
        {
            sum = sum + i;
        }
        Console.WriteLine(sum);
    }

    private static void Task9()
    {
        int i = 1, n = 3, result;
        do
        {
            result = n * i;
            Console.WriteLine("{0} * {1} = {2}", n, i, result);
            i++;
        } while (i <= 10);
    }

    private static void Task10()
    {
        int[] numbers = new int[5] { 3, 5, 9, 8, 15 };
        int multiplication = 1;
        foreach (int i in numbers)
        {
            multiplication = multiplication * i;
        }
        Console.WriteLine(multiplication);
    }

    private static void Task11()
    {
        int counter = 0;
        int x = 2048;
        do
        {
            x = x / 2;
            counter++;
        }
        while (x >= 10);
        Console.WriteLine(counter);
    }

    private static void Task12()
    {
        string[] worldsList = new[] { "World", "Buy", "Hello", "Buy" };
        int counter = 1;
        foreach (string labas in worldsList)
        {
            if (labas.Equals("Hello"))
            {
                Console.WriteLine("Labas!");
                break;
            }
            counter++;
        }
        Console.WriteLine(counter);
    }

    private static void Task13()
    {
          int[] numbers = new int[5] { 2, 4, 8, 10, 25 };
          int firstPosition = 0;
          int lastPosition = numbers.Length - 1;
          Console.WriteLine(numbers[firstPosition] + numbers[lastPosition]);
    }

    private static void Task14()
    {
          int[] numbers = new int[5] { 2, 4, 8, 10, 25 };
          int min = numbers[0];
          int max = numbers[0];
          int indexMin = 0;
          int indexMax = 0;
          for (int i = 0; i<numbers.Length; i++)
          {
            if (numbers[i] < min)
            {
                min = numbers[i];
                indexMin = i;
            }
            if (numbers[i] > max)
            {
                max = numbers[i];
                indexMax = i;
            }
          }
          int sumIndexes = indexMin + indexMax;
          Console.WriteLine(sumIndexes);
    }
}