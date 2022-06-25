// Задача 25: Напишите цикл, который принимает на вход два натуральных числа 
//(A и B) и возводит число A в степень B.

int number, power;
Console.WriteLine("_________________");
Console.WriteLine("Задача 25");
Console.WriteLine("Введите два числа: ");
number = Convert.ToInt32(Console.ReadLine());
power = Convert.ToInt32(Console.ReadLine());
Task25(number, power);
Console.WriteLine("_________________");
void Task25(int currentNumber, int currentPower)
{
    int result = currentNumber;
    int count = 1;
    while (count < currentPower)
    {
        result *= currentNumber;
        count++;
    }
    Console.WriteLine($"{number} в степени {power} = {result}");
}
