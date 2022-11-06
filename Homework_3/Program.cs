
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
        Task8();
        Task9();
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
        Console.Write("Input any number : ");
        num1 = Convert.ToInt32(Console.ReadLine());
        num2 = num1 % 2;
        if (num2 == 0)
            Console.WriteLine("{0} is an even integer.\n", num1);
        else
            Console.WriteLine("{0} is an odd integer.\n", num1);
    }

    private static void Task8()
    {
        Console.Write("Input any number : ");
        int A = Convert.ToInt32(Console.ReadLine());
        if (A < 50 & A != 37 & A >= 32)
        {
            Console.WriteLine("Working");
        }
        else if (A == 0 | A == 15)
        {
            Console.WriteLine("Working");
        }
        else
        {
            Console.WriteLine("Not working");
        }

    }

    private static void Task9()
    {
        Console.Write("Input a first number : ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input a second number : ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input an arithmetic sign (* , / , - , +) : ");
        char sign = Convert.ToChar(Console.ReadLine());
        int result = 0;
        switch (sign)
        {
            case '+':
                result = firstNumber + secondNumber;
                break;
            case '-':
                result = firstNumber - secondNumber;
                break;
            case '/':
                result = firstNumber / secondNumber;
                break;
            case '*':
                result = firstNumber * secondNumber;
                break;
            default:
                Console.WriteLine("Unknow arithmetic sign!");
                break;
        }
        Console.WriteLine(firstNumber + " " + sign + " " + secondNumber + " = " + result);
    }

}
