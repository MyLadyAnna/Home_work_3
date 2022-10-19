// Дано число обозначающее день недели. 
// Выяснить является номер дня недели выходным
Console.Clear();
Console.Write("Введите число от 1 до 7: ");
int week = int.Parse(Console.ReadLine() ?? "0");

if(week == 6 || week == 7)
{
    Console.WriteLine("Выходной день");
}
else
{
Console.WriteLine("Будний день");
}
