// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

void Metod()
{
   Console.Write("Введите число: ");
   int i = Convert.ToInt32(Console.ReadLine());
   int sum=0;
   sum=sum+i%10;
   while(i>10) 
   {
      i=i/10;
      sum=sum+i%10;
   }

   Console.WriteLine(sum);
}
Metod();