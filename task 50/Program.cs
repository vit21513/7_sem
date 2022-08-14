//Задача 50. Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет


int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 100);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j == 0) Console.Write("[");
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],3},");
            else Console.Write($"{array[i, j],3}]");
        }
        Console.WriteLine();
    }
}

int UserInputInt(string userInputStr)
{
    Console.WriteLine(userInputStr);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;

}

void PrintIndexMatrix(int[,] array, int indStrok, int indexStolb, int indS, int indStr)
{
    if (indStrok > indStr || indexStolb > indS) Console.WriteLine("Такого элемента нет в массиве");
    else if (indStrok <= 0 || indexStolb <= 0) Console.WriteLine("такого элемента нет в массиве");
    else Console.WriteLine($" Значение числа по введенному индексу составляет {array[indStrok - 1, indexStolb - 1]}");
}

int m = UserInputInt("Введите   длину строки масива ");
int n = UserInputInt("Введите  длину  столбцов масива ");
int[,] matrixResult = GetMatrix(m, n);
PrintMatrix(matrixResult);
Console.WriteLine();
int indexLine = UserInputInt("Введите  номер строки масива ");     // ввод индексов по "человечески с 1"
int indexСolumn = UserInputInt("Введите  номер столбца масива ");
PrintIndexMatrix(matrixResult, indexLine, indexСolumn, m, n);


