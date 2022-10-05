/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/

Console.Clear();
Console.WriteLine("Введите размер массива: ");
int sizearray = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите минимальный элемент массива: ");
int minarray = int.Parse(Console.ReadLine());

Console.WriteLine("Введите максимальный элемент массива: ");
int maxarray = int.Parse(Console.ReadLine());

double [] array = GetFillArray(sizearray,minarray,maxarray);

double [] GetFillArray (int sizearray,int minarray,int maxarray)
{
    double[]result=new double[sizearray];
    for (int i = 0; i < sizearray; i++)
    {
       result[i]=new Random().Next(minarray*10,maxarray*10)/10.0;
    } 
    return result;
}
Console.WriteLine($"[{String.Join(",", array)}]");

double max_element = array[0];
double min_element = array[0];

for (int z = 1; z < sizearray; z++)
{
    if (max_element < array[z])
    {
        max_element = array[z];
    }
    else if (min_element > array[z]);
    {
        min_element = array[z];
    }
}

double diffrent = max_element - min_element;

Console.WriteLine($"Максимальный элемент массива равен -> {max_element}");
Console.WriteLine($"Минимальнный элемент массива равен -> {min_element}");

Console.WriteLine($"Разницу между максимальным и минимальным элементов массива равнa -> {diffrent}");


