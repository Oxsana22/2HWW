// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]


// ВЕРНЫ ОБА РЕШЕНИЯ!!!!!

Console.WriteLine("Write number");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
array[i] = new Random().Next(-1, 10);
Console.Write($"{array[i]}, ");
}
Console.WriteLine();

for (int i = 0; i < n; i++)
{
array[i] = -array[i];
Console.Write($"{array[i]}, ");
}



// Console.Write("Введите число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[n];
// int[] oposite = new int[n];

// for (int i = 0; i < array.Length; i++)
// {
// array[i] = new Random().Next(-100, 101);

// if (i!=array.Length-1)
// Console.Write($"{array[i]}, ");
// else Console.WriteLine($"{array[i]}");
// if (i!=array.Length-1);

// }
// for (int j = 0; j < array.Length; j++)
// {
// oposite[j] = array[j] * -1;
// Console.Write($"{oposite[j]}, ");
// }