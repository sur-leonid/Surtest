int Max(int arg1, int arg2, int arg3)
{
    int result = arg1;
    if(arg2> result ) result = arg2;
    if(arg3> result ) result = arg3;
    return result;
}
//              0   1   2   3    4   5   6   7  8      ИНДЕКСЫ МАССИВА
int []array = { 11, 211, 31, 41, 15, 61, 17, 18, 19 };
array[0] = 12; // Обращаемся в массив для того чтобы ЗАПИСАТЬ-изменить в нем значение(с 11 на 12)
Console.Write ( "array = " );
Console.WriteLine(array[0]);// обращаемся в масив указвая индекс значениее которго хотим вывести(12)


 int result = Max(
     Max(array[0], array[1], array[2]),
     Max(array[3], array[4], array[5]),
     Max(array[6], array[7], array[8]));


 Console.Write ( "result = " );
 Console.WriteLine( result );