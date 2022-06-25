// Задача 27: Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе.

int number;
Console.WriteLine("_________________");
Console.WriteLine("Задача 27");
Console.WriteLine("Введите число : ");
number = Convert.ToInt32(Console.ReadLine());
Task27(number);

void Task27(int currentNumber)
{
    int sum = 0;
    int startNumber = currentNumber;
    while(currentNumber > 0)
    {
        sum += currentNumber % 10;
        currentNumber /= 10;  
    }
    Console.WriteLine($"В числе {startNumber} сумма цифр равна {sum}");
}