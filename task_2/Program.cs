// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координаты первой точки по оси Х");
double firstDotX = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси Y");
double firstDotY = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты первой точки по оси Z");
double firstDotZ = Double.Parse(Console.ReadLine()); 
Console.WriteLine("Введите координаты второй точки по оси X");
double secondDotX = Double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки по оси Y");
double secondDotY = Double.Parse(Console.ReadLine()); 
Console.WriteLine("Введите координаты второй точки по оси Z");
double secondDotZ = Double.Parse(Console.ReadLine()); 

double dotDistanceX = Math.Pow((secondDotX - firstDotX), 2);
double dotDistanceY = Math.Pow((secondDotY - firstDotY), 2);
double dotDistanceZ = Math.Pow((secondDotZ - firstDotZ), 2);
double dotDistance = Math.Sqrt(dotDistanceX + dotDistanceY + dotDistanceZ);
dotDistance = Math.Round(dotDistance, 2);

Console.WriteLine($"Расстоянием между точками ({firstDotX}, {firstDotY}, {firstDotZ}) и ({secondDotX}, {secondDotY}, {secondDotZ}) является {dotDistance}");