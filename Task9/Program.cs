﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int number = new Random().Next(10, 100); //10, 99+1
Console.WriteLine($"Случайное число из отрезка 10 - 99 => {number}");

// int firstDigit = number / 10;
// int secondDigit = number % 10;

// if (firstDigit == secondDigit) Console.WriteLine("Числа равны");
// else
// {
//int max = firstDigit;
//if (secondDigit > max) max = secondDigit ? firstDigit : secondDigit

// Console.WriteLine($"Наибольшая цифра числа {nunber} =>");
// Console.WriteLine(firstDigit > secondDigit ? firstDigit : secondDigit);
//Console.WriteLine($"Наибольшая цифра числа {nunber} => {max} ");
// }
int MaxDigit(int num)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit == secondDigit) return -1;
    return firstDigit > secondDigit ? firstDigit : secondDigit;    
}

int maxDigit = MaxDigit(number);
string result = maxDigit != -1 ? maxDigit.ToString() : "Цыфры одинаковые";
Console.WriteLine($"Наибольшая цифра числа {number} => {result} ");
