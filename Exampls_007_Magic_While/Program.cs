Console.Clear();// очистка консоли  в начале работы приложения
//Console.SetCursorPosition(10, 4);
//Console.WriteLine("+");

int xa = 40, ya = 1;
    // int xa = 1, ya = 1,    можно просто через запятую хоть весь список 
int xB = 1, yB = 15;
int xc = 80;
int yc = 15;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xB, yB);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+"); 

int x = xa, y = xB;

int count = 0;

while (count < 10000)
{
    int what = new Random().Next(0, 3); // [0;3)  т.е. числа 0 1 2 
if(what == 0)
{
  x = (x+xa)/2;
  y = (y+ya)/2;   
}

if(what == 1)
{
  x = (x+xB)/2;
  y = (y+yB)/2;   
}

if(what == 2)
{
  x = (x+xc)/2;
  y = (y+yc)/2;   
}
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
count++;  // тоже самое   count +=1   или   count++(если увеличиваем именно на 1)

}