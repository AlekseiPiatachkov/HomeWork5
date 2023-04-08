/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
Console.Write("Введите количество элементов в массиве ");

int length = int.Parse(Console.ReadLine());
int[] array = CreationArray(length);

PrintArray(array);
GetSumNoEvenNumber(array);

int[] CreationArray(int length)
{
    int[] array = new int[length];
    Random random = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = random.Next(-9, 10);
    }
    return array;
}

void PrintArray(int[] arr)
{
    Console.Write($" [{string.Join(",", arr)}]");
}

void GetSumNoEvenNumber(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum = sum + arr[i];
    }
    Console.Write($" -> {sum}");
}