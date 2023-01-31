// копирование массива
void PrintArray(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        Console.Write(arg[i] + " ");
    }
}

void FillArray(int[] arg)
{
    for (int i = 0; i < arg.Length; i++)
    {
        arg[i] = new Random().Next(1,10);
    }
}

int[] CopyArray(int[] arg)
{
    int[] Result = new int[arg.Length];
    for (int i = 0; i < arg.Length; i++)
    {
        Result[i] = arg[i];
    }
    return Result;
}

Console.Write("Введите длину массива: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int[N];

FillArray(array);

Console.WriteLine("Сгенерирован массив 1: ");

PrintArray(array);

Console.WriteLine();
Console.WriteLine("Сделана его копия: ");
PrintArray(CopyArray(array));

