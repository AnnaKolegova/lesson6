void Zadacha43()
{
Console.WriteLine("Введите угловой коэффициент первой прямой");
double k1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки пересечения первой прямой с осью OY");
double b1=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите угловой коэффициент второй прямой");
double k2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y точки пересечения второй прямой с осью OY");
double b2=Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Точка пересечения прямых ({Math.Round((b2-b1)/(k1-k2),1)};{Math.Round(k1*(b2-b1)/(k1-k2)+b1,1)})");
}
Zadacha43();