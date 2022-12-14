// Домашняя работа 5.
// Задача 1.Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
 
 /*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
CreateRandomArray(numbers);
Console.Write("Вот наш массив: ");
ShowArray(numbers);
int count = 0;
for (int a = 0; a < numbers.Length; a++)
if (numbers [a] % 2 == 0)
count ++;

Console.Write($"Всего {numbers.Length} чисел, {count} из них четные");
void CreateRandomArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}

void ShowArray(int[] numbers) 
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " "); 
    }

Console.Write("] ");

Console.WriteLine();
}

*/
//Задача 2.Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [size];
CreateRandomArray(numbers);
Console.Write("Вот наш массив: ");
ShowArray(numbers);
int sum = 0;
for (int a = 0; a < numbers.Length; a+=2)
sum = sum + numbers[a];


Console.Write($"Всего {numbers.Length}, сумма элементов на нечетных позициях= {sum} ");
void CreateRandomArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(1,10);
    }
}

void ShowArray(int[] numbers) 
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " "); 
    }

Console.Write("] ");

Console.WriteLine();
}

*/
//Задача 3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
/*
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double [size];
CreateRandomArray(numbers);
Console.Write("Вот наш массив: ");
ShowArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < numbers.Length; a++)
{
    if(numbers[a] > max)
        {
            max = numbers[a];
        }
    if (numbers[a] < min)
       {
            min = numbers[a];
       }

}
Console.WriteLine($"Всего {numbers.Length} чисел, Максимальное значение = {max},минимальное значение ={min} ");
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");

void CreateRandomArray(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] =Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}
void ShowArray(double[] numbers) 
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " "); 
    }

Console.Write("] ");

Console.WriteLine();
}

*/
