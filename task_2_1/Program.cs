// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

double GetNumber(string message)
{
double result = 0;

    while(true)
    {
        Console.WriteLine(message);

            if(double.TryParse(Console.ReadLine(), out result))
            {
                break;
            }
            else
            {
                Console.WriteLine("Введено не число. Повторите ввод.");
            }
    }
    return result;
}

double firstDotX = GetNumber("Введите первую координату по оси Х");
double firstDotY = GetNumber("Введите первую координату по оси Y");
double firstDotZ = GetNumber("Введите первую координату по оси Z");
double secondDotX = GetNumber("Введите вторую координату по оси Х");
double secondDotY = GetNumber("Введите вторую координату по оси Y");
double secondDotZ = GetNumber("Введите вторую координату по оси Z");

double dotDistanceX = Math.Pow((secondDotX - firstDotX), 2);
double dotDistanceY = Math.Pow((secondDotY - firstDotY), 2);
double dotDistanceZ = Math.Pow((secondDotZ - firstDotZ), 2);
double dotDistance = Math.Sqrt(dotDistanceX + dotDistanceY + dotDistanceZ);
dotDistance = Math.Round(dotDistance, 2);

Console.WriteLine($"Расстоянием между точками ({firstDotX}, {firstDotY}, {firstDotZ}) и ({secondDotX}, {secondDotY}, {secondDotZ}) является {dotDistance}");