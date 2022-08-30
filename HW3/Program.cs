// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет

// 12821 -> да

// 23432 -> да

int Palindrom()
{
Console.Write("Введите целое пятизначное число, ");
 int i= Convert.ToInt32( Console.ReadLine()  );

if ( i>0 && i<100000)
{
    if ( i /10000 == i % 10 && i/1000%10 == i/10%10) 
        {
            Console.Write("Да");
        }
    else 
        {
            Console.WriteLine(Palindrom);
        }
}
else
{
    Console.Write("Надо вводить только положительные пятизначные числа");
}
}

try
{
    Console.WriteLine();
}
catch
{
    Console.Write("Надо вводить только числа!");
}






// Console.Write("Введите целое пятизначное число, ");
//  int i= Convert.ToInt32( Console.ReadLine()  );
// if ( i>0 && i<100000)
// {
//     if ( i /10000 == i % 10 && i/1000%10 == i/10%10) 
//     {
//     Console.Write("Да");
//     }
//     else 
//         {
//         Console.Write("Нет");
//         }
// }
// else
// {
//     Console.Write("Введите пятизначное чиисло!");

// }