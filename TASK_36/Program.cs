/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(-100, 100);
    }
}

int SumElementOfOddPosition(int[] array2)
{
    int result = 0;
    for (int i = 1; i < array2.Length; i = i + 2)
    {
        result = result + array2[i];
    }
    return result;
}

void PrintArray(int[] array3)
{
    Console.Write("[");
    for (int i = 0; i < array3.Length; i++)
    {
        Console.Write(array3[i]);
        if(i != array3.Length-1)
        {
            Console.Write(", ");
        }

    }
    Console.Write("] -> ");
}

int[]array=new int[4];
FillArray(array);
PrintArray(array);
int result = SumElementOfOddPosition(array);
Console.Write($"{result}");

