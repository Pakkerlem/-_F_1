// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.



void InifinityQ()
{
    while (true)
    {
        Console.Write("Введите число: ");
        int num = Convert.ToInt32(Console.ReadLine());
        if (num * 2 % 2 == 0)
        {
            Console.WriteLine("[STOP]");
            break;
        }


    }

}

InifinityQ();