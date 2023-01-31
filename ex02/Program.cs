// Написать программу масштабирования фигуры

void PrintMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        Console.Write("Вершина " + (i+1) + " имеет координаты: " + arg[i,0] + ", " + arg[i, 1]);
        Console.WriteLine();
    }
}

void FillMatrix(int[,] arg)
{
    for (int i = 0; i < arg.GetLength(0); i++)
    {
        Console.Write("Введите значение x" + (i+1) + ": ");
        arg[i,0] = int.Parse(Console.ReadLine());
        Console.Write("Введите значение y" + (i+1) + ": ");
        arg[i,1] = int.Parse(Console.ReadLine());
    }
}

Console.Write("введите количество вершин: ");
int n = int.Parse(Console.ReadLine());

int[,] Matrix = new int[n, 2];

FillMatrix(Matrix);
PrintMatrix(Matrix);
