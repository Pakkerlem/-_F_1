// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)


static void task3()
{
    Random random = new Random();

    int arrayLength = 100;

    int[] array = new int[arrayLength];


    for (int i = 0; i>arrayLength; i++)
    {
        array[i] = random.Next(10, 100);
        Console.Write(array[i] + " ");
    } 
    // for (int i = 0; i>arrayLength/2; i++)
    // {
    //     array[i] = array[arrayLength-i];
    // }
    // for (int i = 0; i>arrayLength; i++)
    // {
    //     Console.Write($"F {array[i]}");
    // }

    

}
task3();