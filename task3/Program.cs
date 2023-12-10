// Напишите программу, которая перевернёт одномерный массив (первый элемент станет последним, второй – предпоследним и т.д.)




    static void task3()
    {
        // Задаем длину массива
        int arrayLength = 10;
        
        // Создаем массив с рандомными числами
        int[] randomArray = new int[arrayLength];
        Random random = new Random();
        
        Console.WriteLine("Исходный массив со случайными числами:");
        for (int i = 0; i < arrayLength; i++)
        {
            randomArray[i] = random.Next(1, 101); 
            Console.Write(randomArray[i] + " ");
        }

        ReverseArray(randomArray); 

        Console.WriteLine("\n\nПеревернутый массив:");
        foreach (int num in randomArray)
        {
            Console.Write(num + " ");
        }
    }

    static void ReverseArray(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;

        while (left < right)
        {
            
            int temp = arr[left];
            arr[left] = arr[right];
            arr[right] = temp;

            
            left++;
            right--;
        }
    }
task3();



