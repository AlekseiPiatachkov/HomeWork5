/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76
*/

Console.Write("Введите количество элементов в массиве ");

int length = int.Parse(Console.ReadLine());
double[] array = CreationArray(length);
double maxNumber = array[0];
double minNumber = array[0];

PrintArray(array);
GetMaxNumber(array);
GetMinNumber(array);
GetDifferentNumber(maxNumber, minNumber); 


double[] CreationArray(int length)
{
    double[] array = new double[length];

    for (int i = 0; i < length; i++)
    {
        array[i] = Math.Round(new Random().Next(1, 10)
         + new Random().NextDouble(), 3);
    }
    return array;
}

void PrintArray(double[] arr)
{
    Console.Write($" [{string.Join(",", arr)}] -> ");
}

void GetMaxNumber(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxNumber) maxNumber = arr[i];
    }
    Console.Write($"{maxNumber} - ");
}

void GetMinNumber(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minNumber) minNumber = arr[i];
    }
    Console.Write($"{minNumber} = ");
}

void GetDifferentNumber(double max, double min)
{
    Console.Write($"{max - min}");
} 