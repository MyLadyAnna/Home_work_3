// Задать номер четверти, показать диапазоны для возможных координат
Console.Clear();
Console.Write("Введите номер четверти ");
int number = int.Parse(Console.ReadLine() ?? "0");

if(number == 1)
{
    Console.WriteLine($"У {number} четверти диапазон координат: х = (0;+ бесконечность), y= (0;+ бесконечность)");
}
else if(number == 2)
{
    Console.WriteLine($"У {number} четверти диапазон координат: x = (- бесконечность; 0), y = (0;+ бесконечность)");
}
else if(number == 3)
{
    Console.WriteLine($"У {number} четверти диапазон координат: x = (- бесконечность; 0), y = (- бесконечность; 0)");
}
else if(number == 4)
{
    Console.WriteLine($"У {number} четверти диапазон координат: x = (0;+ бесконечность), y = (- бесконечность; 0)");
}
else
{
    Console.WriteLine("Введите значене от 1 до 4");
}