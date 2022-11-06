
using System;

class Program
{
    static void Main(string[] args)
    {
        Task1();
        Task2();
        Task3();
        Task4();
        Task5();
        Task6();
        Task7();
    }

    private static void Task1() 
    {
        int num = 20;
        num += 5;
        Console.WriteLine($"Variable: {num}");
        Console.ReadLine();
    }

    private static void Task2() 
    {
        Console.Write("Enter a four digit number:");
        string inputData = Console.ReadLine();
        int result = Int32.Parse(inputData);
        int year = result / 365;
        int diffDays = result - year * 365; // the number of days that were not enough for a full year
        int month = diffDays / 30;
        int day = diffDays - month * 30;
        Console.WriteLine("Year = " + year);
        Console.WriteLine("Month = " + month);
        Console.WriteLine("Day = " + day);
    }
    private static void Task3() 
    {
        Console.Write("Enter any number:");
        string inputData = Console.ReadLine();
        int result = Int32.Parse(inputData);
        result = result + result * 2;
        Console.WriteLine("Result = " + result);
    }
    private static void Task4() 
    {
        sbyte a = -34;
        byte b = 4;
        string c = "Hello";
        char d = 'R';
        float i = 23.93433222f;
        ushort f = 40000;
        bool g = true;
        int h = 0;
    }
    private static void Task5() 
    {
        Console.Write("Enter a value with short type:");
        string short_inputData = Console.ReadLine();
        short value0 = Convert.ToInt16(short_inputData);
        Console.Write("Enter a value with ulong type:");
        string ulong_inputData = Console.ReadLine();
        ulong value1 = Convert.ToUInt64(ulong_inputData);
        Console.Write("Enter a value with char type:");
        string char_inputData = Console.ReadLine();
        char value2 = Convert.ToChar(char_inputData);
        Console.Write("Enter a value with double type:");
        string double_inputData = Console.ReadLine();
        double value3 = Convert.ToDouble(double_inputData);
    }
    private static void Task6() 
    {
        sbyte num = -5;
        num *= 7;
        num--;
        Console.WriteLine($"Variable: {num}");
        Console.ReadLine();
    }
    private static void Task7() 
    {
        int num1, num2;
        Console.Write("Input an number : ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = num1 % 2;
        if (num2 == 0)
            Console.WriteLine("{0} is an even integer.\n", num1);
        else
            Console.WriteLine("{0} is an odd integer.\n", num1);
    }

}
