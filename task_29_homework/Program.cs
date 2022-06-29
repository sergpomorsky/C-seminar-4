// Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.
int [] array = new int [8];
{Console.Write($"[");
for(int i = 0; i <= array.Length - 1; i++)
    {
    array[i] = new Random(). Next(0, 99);
    Console.Write($"{array[i]},"); 
    }
    Console.Write($"]");
}
Console.WriteLine();

