// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] array = new int[8];

void FillArray (int[] arr)
{
    int length = arr.Length;
    for (int i = 0; i < length; i++)
    {
        Console.Write("Введите элемент массива: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
}

void PrintArray(int[] mas)
{
    int length = mas.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (i == length-1) Console.Write($"{mas[i]}"); 
        else Console.Write($"{mas[i]}, "); 
    }
    Console.Write("]");
}

FillArray(array);
PrintArray(array);
