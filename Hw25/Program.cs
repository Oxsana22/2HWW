// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16
void Method1()
{
    Console.Write("Введите число A: ");
    int A = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите число B: ");
    int B = Convert.ToInt32(Console.ReadLine());
    int i=0;
    int n=A;
    for (i=1;i<B;i++)
    {
        n=n*A;
    }
    Console.Write(n);
}
Method1();
