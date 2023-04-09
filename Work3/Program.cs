/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите количество элементов в массиве ");

int length = int.Parse(Console.ReadLine());
int[] array = CreationArray(length);
int maxNumber = array[0];
int minNumber = array[0];

PrintArray(array);
GetMaxNumber(array);
GetMinNumber(array);
GetDifferentNumber(maxNumber, minNumber); 


int[] CreationArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(1, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write($" [{string.Join(",", arr)}] -> ");
}

void GetMaxNumber(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }
    Console.Write($"{maxNumber} - ");
}

void GetMinNumber(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber) minNumber = arr[i];
    }
    Console.Write($"{minNumber} = ");
}

void GetDifferentNumber(int max, int min)
{
    Console.Write($"{maxNumber - minNumber}");
}