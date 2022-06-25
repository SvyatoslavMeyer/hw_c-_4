// Задача 25: Напишите цикл, который принимает на вход два натуральных числа 
//(A и B) и возводит число A в степень B.

int number1, power;
Console.WriteLine("_________________");
Console.WriteLine("Задача 25");
Console.WriteLine("Введите два числа: ");
number1 = Convert.ToInt32(Console.ReadLine());
power = Convert.ToInt32(Console.ReadLine());
Task25(number1, power);
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
    Console.WriteLine($"{number1} в степени {power} = {result}");
}


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

// Задача 29: Напишите программу, которая задаёт массив из 8 
// случайных целых чисел и выводит отсортированный по модулю массив.

int[] array = new int[3] {6, 1, -33};

Console.WriteLine();
Console.WriteLine("Задача 29");
PrintArray(array);
Task29(array);
PrintArray(array);

void PrintArray(int[] currentArray)
{
    Console.WriteLine("Вывод массива на печать...");
    for (int i = 0; i < currentArray.Length; i++)
    {
        Console.Write(currentArray[i] + "\t");
    }
    Console.WriteLine();
}

void Task29(int[] currentArray)
{
    int lastIndex = currentArray.Length - 1;
    for (int i = lastIndex; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (Math.Abs(currentArray[j]) > Math.Abs(currentArray[j+1]))
            {
                int temp = currentArray[j];
                currentArray[j] = currentArray[j+1];
                currentArray[j+1] = temp;
            }
        }
    }
}
