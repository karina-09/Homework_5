Console.Clear();


// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

/*int[] Array = GetArray (10, 100, 999);
System.Console.WriteLine($"[{String.Join(",", Array)}]");
System.Console.WriteLine($"Количество четных чисел в массиве {GetCount(Array)}");


int[] GetArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}

int GetCount(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item % 2 == 0)
        count++;
    }
    return count;
}*/



// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных индексах. [3, 7, 23, 12] -> 19   [-4, -6, 89, 6] -> 0

/*int[] Array = GetArray (4, 100, 999);
System.Console.WriteLine($"[{String.Join(",", Array)}]");
System.Console.WriteLine($"Сумма элементов, стоящих на нечетных индексах = {GetSum(Array)}");

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(100, 1000);
    }
    return res;
}

int GetSum (int[] array)
{
    int sum = 0;
    for(int i =0; i < array.Length; i++)
    {
        if(i % 2 == 1) sum = sum + array[i];
    }
    return sum;
}*/



// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
// Результат запишите в новом массиве. [1 2 3 4 5] -> 5 8 3   [6 7 3 6] -> 36 21


/*int[] Array = GetArray (5, 0, 5);
System.Console.WriteLine($"[{String.Join(",", Array)}]");
System.Console.WriteLine(String.Join(",", NewArray(Array)));

int[] GetArray (int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for(int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}

int [] NewArray (int[] array)
{
    int size = array.Length/2;
    if(array.Length%2 ==1) size++;
    int [] result = new int[size];
    for(int i = 0; i < array.Length/2; i++)
    {
        result[i] = array[i] * array [array.Length - 1 -i];
    }
    if(array.Length % 2 == 1) result[size-1] = array[array.Length/2];
    return result;
}*/