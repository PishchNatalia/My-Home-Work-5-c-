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





