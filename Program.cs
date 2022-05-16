//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
Console.Clear();
System.Console.WriteLine();

int number = 3;
int exponent = 5;
int count = 2;
int result = number;

while (count < exponent)
{
    result = result * number;
    count++;
}

System.Console.WriteLine($"{number} ^ {exponent} = {result}");
System.Console.WriteLine();

//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
Console.Clear();
System.Console.WriteLine();

int num = new Random().Next(1, 100000);
int sumDigit = 0;
System.Console.Write($"Сумма цифр числа {number} равна ");

while (number > 0)
{
    int digit = number % 10;
    sumDigit = sumDigit + digit;
    number = number / 10;
}

System.Console.WriteLine(sumDigit);
System.Console.WriteLine();

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int N = 8;

int[] SetArray(int x)
{
    int[] arr = new int[x];
    for (int i = 0; i < x; i++)
    {
        arr[i] = new Random().Next(1, 100);
    }
    return arr;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        System.Console.Write($"{array[i]} ");
}

PrintArray(SetArray(N));