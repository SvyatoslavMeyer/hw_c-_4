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