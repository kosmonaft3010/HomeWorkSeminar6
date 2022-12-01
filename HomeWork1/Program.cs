// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 4

int PositiveNumbers = 0;
bool b = true;
while (b)
{
    Console.Write("Хотите ввести число? Если ДА наберите 1: ");

    int n = Convert.ToInt32(Console.ReadLine());

    if (n == 1)
    {
        Console.Write("Введите число: ");
        int m = Convert.ToInt32(Console.ReadLine());
        if (m > 0)
        {
            PositiveNumbers = PositiveNumbers + 1;
        }
    }
    else
    {
        Console.Write($"Спасибо! Чисел больше 0 введено {PositiveNumbers} раз");
        b = false;
    }
}
