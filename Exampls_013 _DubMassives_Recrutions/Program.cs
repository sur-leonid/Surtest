 //Двумерный массив
 
 
//  string[,] table = new string[2,5];
// // String.Empty
// // table [0,0] table [0,1] table [0,2] table [0,4]
// // table [1,0] table [1,1] table [1,2] table [1,4]

// table [1, 2] = "слово";
// for (int rows = 0; rows < 2; rows++)
// {
//  for (int columns = 0; columns < 5; columns++)
//  {
//  Console.WriteLine($"-{table[rows, columns]}-");
//  }
// }
//****************************************************************************************************
// Двуменрный массив  matrix
void PrintArray(int[,] matr) //метод подпраграмма для вывода печати массиваа на экран
{
    for (int i = 0; i < matr.GetLength(0); i++) // счетчик щелкающий строки
    {
    for (int j = 0; j < matr.GetLength(1); j++) // счетчик щелкающий столбцы
        {
        Console.Write($"{matr[i, j]} ");
        }
    Console.WriteLine();
    }
}
void FillArray(int[,] matr)//  медтод который заполняет маассив случайными числами
{
    for (int i = 0; i < matr.GetLength(0); i++)// счетчик щелкающий строки
    {
        for (int j = 0; j < matr.GetLength(1); j++)// счетчик щелкающий столбцы
        {
        matr[i,j] = new Random().Next(1,10);//[1; 10)
        }
    }
}

int[,] matrix = new int[3, 4];//задаем масивв  MATRIX который будем передавать чнрез аргументы в масивв  MATR- в подпрограмме void PrintArray(int[,] matr)
PrintArray(matrix); // в этом запросе для метода PrintArray 
//                      мы передаем  аргументы в void PrintArray(int[,] MATR), 
                       //те что были заданы в массиве int[,] MATRIX = new int[3, 4];
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
