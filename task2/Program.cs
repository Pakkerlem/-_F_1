// Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
void task1()
{
    Random random = new Random();
    int arrayLength = 100;

    int[] array = new int[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    int count = 0;
    foreach (int num in array)
    {
        if (num % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine($"Количетсво четных чисел в массиве: {count} ");
}
task1();