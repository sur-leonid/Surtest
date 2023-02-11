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
//************************************************************************************************************************
//                             Р Е К У Р С И Я 
//    вычисление  факториала 
Double Factorial(int n)    /// здесь можно  чтобы возращался  формат или  "- int "  или побольше   "- Double"
{
 // 1! = 1
 // 0! = 1
 if(n == 1) return 1;
 else return n * Factorial(n-1);
}
Console.WriteLine($"факториал {Factorial(3)}");   // 1 * 2 * 3 = 6  // факториал от 3
//    вычисление  ФИБОНАЧИ    --- каждое следующее число равно сумме двух предыдущих
// f(1) = 1
// f(2) = 1
// f(n) = f(n-1) + f(n-2)

Double  Fibonacci(int n) // подпрограмма   фибоначи //здесь можно  чтобы возращался  формат или  "- int "  или побольше   "- Double"
{
 if(n == 1 || n == 2) return 1;
 else return Fibonacci(n-1) + Fibonacci(n-2);
}

for (int i = 1; i < 40; i++)   // задаем  поиск на перве  40 чисел в ряде фибоначи
{
 //Console.WriteLine(Fibonacci(i));
  Console.WriteLine($"f({i}) = {Fibonacci(i)}");
}
