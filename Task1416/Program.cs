// 14. Напишите программу, 
// которая принимает на вход число и проверяет,
//  кратно ли оно одновременно 
//  7 и 23. 14 -> 
//  нет 46 -> 
//  нет 161 -> да  


// Console.WriteLine("Piease enter the 1st number: ");
// int firstNum = Convert.ToInt32(Console.ReadLine());

// bool De1(int num)
// {
//     return num % 7 == 0 && nun % 23 == 0;
// }
// bool result = De1(firstNum);
// Console.WriteLine(result ? "Да" : "Нет" );

// 16. Напишите программу, 
// которая принимает на вход два числа и проверяет, 
// является ли одно число квадратом другого. 
// 5, 25 -> да -4, 
// 16 -> да 25, 5 -> да 
// 8,9 -> нет 

Console.WriteLine("Piease enter the 1st number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Piease enter the 1st number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

bool De1(int num1, int num2)
{
    return (num1*num2==num2 || num2*num2==num1);

}
bool result = De1(firstNum, secondNum);
Console.WriteLine(result ? "Да" : "Нет" );
