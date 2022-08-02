// See https://aka.ms/new-console-template for more information


Console.WriteLine("Task 1\nEnter the number: ");
int number = Convert.ToSByte(Console.ReadLine());
if (number < 0 || number > 100) {
    Console.WriteLine("Error!");    
}
if (number % 3 == 0 && number % 5 == 0) {
    Console.WriteLine("Fizz Buzz");
}
else 
    if (number % 3 == 0) {
        Console.WriteLine("Fizz");
}
else 
    if (number % 5 == 0) {
        Console.WriteLine("Buzz");
}
else 
    if (number % 3 != 0 && number % 5 != 0 && number < 101 && number >= 0) {
        Console.WriteLine($"Your number: {number}");
}

Console.Write("Task 2\nEnter the number: ");
double num1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter the percentage: ");
double num2 = Convert.ToDouble(Console.ReadLine());
if (num2 < 0) {
    Console.WriteLine("You entered a negative number!");
}
else {
    Console.WriteLine($"Your result: {num1 / 100 * num2}.");
}

Console.Write("Task 3\nEnter the number 1: ");
string? num3 = Console.ReadLine();
Console.Write("Enter the number 2: ");
string? num4 = Console.ReadLine();
Console.Write("Enter the number 3: ");
string? num5 = Console.ReadLine();
Console.Write("Enter the number 4: ");
string? num6 = Console.ReadLine();
string? num7 = num3 + num4 + num5 + num6;
Console.WriteLine($"Your number: {num7}");



Console.WriteLine("Task 4\nEnter a six-digit number: ");
int num8  = Convert.ToInt32(Console.ReadLine());
string? num9 = num8.ToString();
if (num9.Length != 6)
{
    Console.WriteLine("Error! Your number is less than 6 characters.");
}
else
{
    Console.Write("Enter 2 numbers to exchange(from 0 to 5).\nEnter the first number: ");
    int num10 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the second number: ");
    int num11 = Convert.ToInt32(Console.ReadLine());
    if (num10 < 0 || num10 > 5 || num11 < 0 || num11 > 5)
    {
        Console.WriteLine("Error! The range of numbers should be from 0 to 5.");
    }
    else
    {
        string num12, num13;
        string[] arr = new string[num9.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = num9[i].ToString();
        }
        num12 = arr[num10];
        num13 = arr[num11];
        arr[num10] = num13;
        arr[num11] = num12;
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Task 5\n:Enter the date:\n");
Console.Write("Enter the day: ");
int day = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the month: ");
int month = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the year: ");
int year = Convert.ToInt32(Console.ReadLine());

DateTime date = new DateTime(year, month, day);
Console.WriteLine(date.ToLongDateString());

if (month == 1 || month == 2 || month == 12)
    Console.WriteLine($"Winter {date.DayOfWeek}");
if (month == 3 || month == 4 || month == 5)
    Console.WriteLine($"Spring {date.DayOfWeek}");
if (month == 6 || month == 7 || month == 8)
    Console.WriteLine($"Summer {date.DayOfWeek}");
if (month == 9 || month == 10 || month == 11)
    Console.WriteLine($"Autumn {date.DayOfWeek}");


Console.Write("Task 6\nTemperature conversion.\nEnter the temperature reading: ");
int num14 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the number:\n1. Celsius.\n2. Fahrenheit.");
int num15 = Convert.ToInt32(Console.ReadLine());
switch (num15) {
    case 1:
        Console.WriteLine($"{5.0 / 9.0 * (num14 - 32)} celcius");
        break;
    case 2:
        Console.WriteLine($"{9.0 / 5.0 * num14 + 32} fahrenheit.");
        break;
    default:
        break;
}

Console.WriteLine("Task 7\nEnter 2 number:");
int num16 = Convert.ToInt32(Console.ReadLine());
int num17 = Convert.ToInt32(Console.ReadLine());
if (num16 > num17) {
    int num18 = num16;
    num16 = num17;
    num17 = num18;
}

for (int i = num16; i <= num17; i++)
{
    if (i % 2 == 0) {
        Console.Write($"{i}, ");
    }
}
Console.WriteLine("\b\b.");








