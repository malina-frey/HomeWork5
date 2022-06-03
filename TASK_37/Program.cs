/*
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

void FillArray(int[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = new Random().Next(1, 10);
    }
}

void ProductOfPairsOfNumbers(int[] array2, int[]array4)
{

    for (int i = 0; i < array2.Length/2; i++)
    {
        
            array4[i] = array2[i] * array2[array2.Length-1 - i];

    }
}
void PrintArray(int[] array3)
{
    for (int i = 0; i < array3.Length; i++)
    {
        Console.Write(array3[i]);
        if (i != array3.Length - 1)
        {
            Console.Write(" ");
        }
    }
}

Console.WriteLine("Укажите длину массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] array = new int[sizeArray];
int[] arr = new int[sizeArray/2];
FillArray(array);
    Console.Write("[");
PrintArray(array);
    Console.Write("]");
ProductOfPairsOfNumbers(array,arr);
 Console.Write(" -> ");
PrintArray(arr);
if (sizeArray%2!=0)
{
     Console.Write(" "+array[sizeArray/2]);
}