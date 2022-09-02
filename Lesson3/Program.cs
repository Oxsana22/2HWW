// Задание - 1 уровень - найти максимальное число и его индекс,
//  найти минимальное число и его индекс, 
//  найти среднее арифметическое всех элементов массива, 
//  2 уровень - обернуть в функцию

Random rd = new Random();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] arr = FillArray(N);

int[] FillArray(int number)
{
    int[] array = new int[number];
    for (int i = 0; i < N; i++)
    {
        array[i] = rd.Next(1, 100);
    }
    return array;
}

void printArray(int[] Array)
{
    foreach (int i in Array)
    {
        Console.Write($"{i}, ");
    }
    Console.WriteLine("");
}

double[] zadacha(int[] array)
{
    //max
    //int N = array.Length;
    int max = array[0];
    int maxIndex = 0;
    for (int i = 0; i < N; i++)
        {
            if (array[i] > max)
            {
                max = array[i];
                maxIndex = i;
            }
        }

    //min
    int min = array[0];
    int minIndex = 0;
    for (int i = 0; i < N; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
            minIndex = i;
        }
           
    }


    //average
    double average = 0;
    foreach(int i in array)
    {
        average += i;
    }
    average = average / array.Length;

    double[] answer = {maxIndex, minIndex, average, max, min};
    return answer;
}
printArray(arr);
double[] answer = zadacha(arr);
Console.WriteLine($" max индекс = {answer[0]}");
Console.WriteLine($" min индекс = {answer[1]}");
Console.WriteLine($" average = {answer[2]}");
Console.WriteLine($" max = {answer[3]}");
Console.WriteLine($" min = {answer[4]}");

