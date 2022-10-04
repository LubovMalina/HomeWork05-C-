/*Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int sizearray = int.Parse(Console.ReadLine());

Console.WriteLine("Введите минимальный элемент массива: ");
int minarray = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальный элемент массива: ");
int maxarray = int.Parse(Console.ReadLine());

int [] array = GetFillArray(sizearray,minarray,maxarray);

int [] GetFillArray (int sizearray,int minarray,int maxarray)
{
    int[]result=new int[sizearray];
    for (int i = 0; i < sizearray; i++)
    {
        result[i]=new Random().Next(minarray, maxarray+1);
    }
    return result;
}
Console.WriteLine($"[{String.Join(",", array)}]");

int summ = 0;
for (int z = 0; z<sizearray; z++)
{
    if (z%2 != 0)
    {
        summ += array[z];
    }
}
Console.WriteLine($"Cумму элементов, стоящих на нечётных позициях равнa -> {summ}");

