//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//  Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

void SumPos()
{
Console.Write("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int []nums = new int [n];
int sum =0;
for (int i=0; i<n;i++)
{
   nums [i] = new Random().Next(100, 999);
   Console.Write($"{nums [i]}, ");

if (nums [i]%2==0) sum ++;
}
Console.WriteLine($" -> {sum } ");
}
SumPos();
