Console.WriteLine("Введите число от 100 до 999:");
    int number = Convert.ToInt32(Console.ReadLine());

    int digit = number / 10;
    int count = digit % 10; 

    Console.WriteLine($"Второе число {count}");

