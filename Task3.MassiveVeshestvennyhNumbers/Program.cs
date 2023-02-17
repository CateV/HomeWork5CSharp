// Задайте массив вещественных чисел. Найдите разницу между 
// максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76
double [] FillArray(int quantity)
{
    double[] massive = new double[quantity];
    for (int index = 0; index < quantity; index++)
    {
        massive[index] = new Random().Next(1, 100);
    }
    return massive;
}
void PrintArray (double [] massive)
{
    for (int i = 0; i<massive.Length; i++)
    {
        System.Console.Write($"{massive [i]}\t");
    }
}
double BetweenMinAndMax (double[]massive)
{
        double min = massive[0];
        for (int i = 1; i<massive.Length;i++)
        {
            if (massive[i]<min)
            {
                min = massive[i];
            }
        }

        double max = massive[0];
        for (int i = 1; i<massive.Length;i++)
        {
            if (massive[i]>max)
            {
                max = massive[i];
            }
        }
double result = max - min;
return result;
}
double[] ourMassive = FillArray (10);
PrintArray (ourMassive);
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {BetweenMinAndMax(ourMassive)}");