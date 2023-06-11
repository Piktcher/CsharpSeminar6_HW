// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int CountPositiveNumbers (int amount)
{
    int positiveNumbers = 0;
    int count = 1;
    while (count <= amount)
    {
        Console.Write($"Введите число номер {count} : ");
        int number = Convert.ToInt32(Console.ReadLine());
        count++;
        if (number > 0) positiveNumbers++;
    }

    return positiveNumbers;
}

Console.Write($"Введите кол-во чисел, среди которых нужно посчитать положительные - ");
int quantity = Convert.ToInt32(Console.ReadLine());

int result = CountPositiveNumbers(quantity);
Console.WriteLine($"Количество положительных чисел среди введенных равно {result}");