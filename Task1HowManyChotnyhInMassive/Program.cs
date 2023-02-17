// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int [] FillArray(int quantity)
{
    int[] massive = new int[quantity];
    for (int index = 0; index < quantity; index++)
    {
        massive[index] = new Random().Next(100, 1000);
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
int FindChet (int [] array)
{
    int count =0;
    for (int i = 0; i<array.Length; i++)
    {
       if (array[i]%2 == 0)
       {
        count++;
       } 
    }
    return count;
}
//в данном случае нельзя, чтобы FillArray был void, так как невозможно его потом использовать
//в функции нахождения количества чётных, который типа int?
int [] ourMassive = FillArray(9);
PrintArray(ourMassive);
System.Console.WriteLine();
int result = FindChet (ourMassive);
System.Console.WriteLine($"в массиве {result} чётных чисел");

