// Задача 1: Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
// Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.





void Main()
{
    while (true)
    {
        Console.WriteLine("Введите целое число или 'q' для выхода:");
        string input = Console.ReadLine();

        if (input == "q")
        {
            Console.WriteLine("Выход из программы...");
            break;
        }

        int number;
        bool isNumber = int.TryParse(input, out number);

        if (isNumber)
        {
            int sum = CalculateSumOfDigits(number);
            if (sum % 2 == 0)
            {
                Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                break;
            }
            else
            {
                Console.WriteLine($"Сумма цифр числа {number} нечётная.");
            }
        }
        else
        {
            Console.WriteLine("Неверный формат ввода. Пожалуйста, введите целое число или 'q' для выхода.");
        }
    }
}

int CalculateSumOfDigits(int number)
{
    int sum = 0;
    while (number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}

Main();