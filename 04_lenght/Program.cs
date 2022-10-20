// Найти расстояние между точками в пространстве 2D/3D
Console.Clear();
Console.Write("Введите коорднату Х 1 числа: ");
double x1 = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите коорднату Y 1 числа: ");
double y1 = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите коорднату Z 1 числа: ");
double z1 = Convert.ToDouble(Console.ReadLine() ?? "0");

Console.Write("Введите коорднату Х 2 числа: ");
double x2 = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите коорднату Y 2 числа: ");
double y2 = Convert.ToDouble(Console.ReadLine() ?? "0");
Console.Write("Введите коорднату Z 2 числа: ");
double z2 = Convert.ToDouble(Console.ReadLine() ?? "0");

double lenght = 0;
 lenght = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)); 
 Console.WriteLine($"Расстояне между точками равно {lenght}");