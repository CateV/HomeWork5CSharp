// Задача 2: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int [] FillArray(int quantity)
{
    int[] massive = new int[quantity];
    for (int index = 0; index < quantity; index++)
    {
        massive[index] = new Random().Next(1, 100);
    }
    return massive;
}
void PrintArray (int [] massive)
{
    for (int i = 0; i<massive.Length; i++)
    {
        System.Console.Write($"{massive [i]}\t");
    }
}
int SummOfElements (int[]massive)
{
    int count = 0;
    for (int i=0;i<massive.Length;i+=2)
    {
      count = count + massive [i];
    }
    return count;
}
int []ourMassive =FillArray(9);
PrintArray(ourMassive);
System.Console.WriteLine();
int summ = SummOfElements (ourMassive);
System.Console.WriteLine($"Сумма элементов массива, стоящих на нечётных позициях, равна {summ}");
