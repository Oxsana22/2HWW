 
 void SquarTableN()
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
    SquarTableN();
}
catch
{
    Console.Write("Надо было вводить числа!");
}


