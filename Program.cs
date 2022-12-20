// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
//  выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

void ChangeArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
           if(i % 2 == 0 && j % 2 == 0)
           {
            array[i,j] = array[i,j]*array[i,j];
           }
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}
void PrintArray(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}



int[,] FillArray(int rows, int columns, int start, int end)
{
    int[,] array = new int[rows, columns];
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            array[i,j] = new Random().Next(start, end + 1);
        }
    }
    return array;
}


int EnterData(string text)
{
    Console.WriteLine(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}


//Запрос количества строк

int rows = EnterData("Введение количества строк");

//Запрос количества столбцов

int columns = EnterData("Введение количества столбцов");
// Создание двухмерного  массива, заполненного случайными числами
int[,] matrix = FillArray(rows, columns, 0, 10);
//Выведение массива на экран
PrintArray(matrix);

//Замените элементы,у которых оба индекса чётные, на их квадраты
Console.WriteLine();
ChangeArray(matrix);

