/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

//int[] array = new int[10];

int[] array = CreationArray(10);

PrintArray(array);
GetCountEvenNumber(array);

int[] CreationArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(100, 999);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write($" [{string.Join(",", arr)}]");
}

void GetCountEvenNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    Console.Write($" -> {count}");
}