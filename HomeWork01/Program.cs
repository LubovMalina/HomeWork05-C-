/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int sizearray = int.Parse(Console.ReadLine());
int[] array = GetRandomArray(sizearray,100,999);

int[] GetRandomArray(int sizearray, int minValue, int maxValue)
{
    int[]result=new int[sizearray];
    for (int i = 0; i < sizearray; i++)
    {
        result[i]=new Random().Next(minValue, maxValue+1);
    }
    return result;
}
Console.WriteLine($"[{String.Join(",", array)}]");

int count = 0;
for (int z = 0; z<sizearray; z++)
{
    if (array[z]%2==0)
    {
        count +=1;
    }
}
Console.WriteLine($"Количество четных чисел в массиве равно -> {count}");

