// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125 


 void CubeTableN()
{
    Console.Write("Введите число ");
    int N = Convert.ToInt32(Console.ReadLine());
    if (N > 0)
    {
        for (int i = 1; i<(N+1); i++) 
        {
        Console.Write($"{ i * i * i } ,");
        }
    }
else
{
    Console.Write("Надо было вводить положительнрое число");
}
}   
try
{
    CubeTableN();
}
catch
{
    Console.Write("Надо было вводить числа!");
}


