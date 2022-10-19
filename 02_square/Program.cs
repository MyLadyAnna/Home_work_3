// По двум заданным числам проверять является ли одно квадратом другого
Console.Clear();
Console.Write("Введите 1 число: ");
int numberA = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите 2 число: ");
int numberB = int.Parse(Console.ReadLine() ?? "0");

if(numberA == numberB*numberB)
{
    Console.WriteLine("Первое введённое число является квадратом второго");
}
else if(numberB == numberA*numberA)
{
    Console.WriteLine("Второе введённое число является квадратом первого");
}
else
{
    Console.WriteLine("Ни одно из введённых чисел не является квадратом другого");
}