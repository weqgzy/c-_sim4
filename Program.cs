﻿int numberA = ReadInt("Введите число: ");
int numberB = ReadInt("Введите степень: ");
ToDegree(numberA, numberB);


void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}