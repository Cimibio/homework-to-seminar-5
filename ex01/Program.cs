// Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
// Написать программу масштабирования фигуры
float[] Calc(int b1, int k1, int b2, int k2)
{
    float[] result = new float[2];
    result[0] = ((b1 - b2) / (k2 - k1));
    result[1] = ((k2 * result[0]) + b2);
    return result;
}

void PrintArray(float[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write(arg[i] + ", ");
    }
}

Console.WriteLine("Ввеедите аргументы для двух прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2");
Console.Write("Введите b1: ");
int b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
int k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
int b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
int k2 = int.Parse(Console.ReadLine());

//Calc(b1,k1,b2,k2);
if (k2 == k1 && b2 != b1)   //прямые парралельны
{
    Console.WriteLine("Линии параллельны!");
}
else if ( k2 == k1 && b2 == b1)  //одна и та же прямая
{
    Console.WriteLine("Это одна и та же линия!");
}
else 
{
Console.Write("Точка пересечения двух прямых заданных уравнениями y = k1 * x + b1, y = k2 * x + b2, имеет координаты: x, y = ");
PrintArray(Calc(b1,k1,b2,k2));
}