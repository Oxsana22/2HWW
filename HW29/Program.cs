// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]
void Mas()
{
    int[] array = new int[8];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t");  
        array[i] = Convert.ToInt32( Console.ReadLine());
    }
    Console.WriteLine("Вывод массива: "); 

    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}
Mas();