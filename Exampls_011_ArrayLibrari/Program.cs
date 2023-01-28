void FILLArray(int[] collection) // заполнение маасива из 10 индексов,
                                 // каждый элемент которого сформирован генератором случайных чисел
{
    int Length = collection.Length;  // длинна массива collection
    int index = 0 ;
    while (index < Length)
    {
        collection[index] = new Random().Next(1, 10); // кладем в индекс(массива collection) рандомное число
                                                       // рандомное число из диапазона от 1 до 10
    //index = index + 1
    index++; //переходим к следующей ячейке (индекса) кда опять положем рандомное число
    }
}

void PrintArray(int[] col) // Метод котрый будет печатать маасив
{
    int count = col.Length;
    int position = 0;
    while (position<count)
    {
        Console.Write ( "position = " );
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find) //Программа  которая ищет номер индекса в массиве в соответствии с 
                                        // со значением   которое мы! зададим !  (от 1 до 10)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;  //  "-1"  СТАВИМ ВМЕСТО "0"  чтобы в финале НАМ ОШИБКА или НЕНАЙДЕНЫЙ ЭЛЕМЕНТ
                            // выходила как   "-1" (если  мы к примеру ищем 500 в массиве МЕНЬШЕ 500 ) 
    while (index < count)
    {
        if (collection[index]==find)
        {
         position = index;
         break;
        }
    index++;
    }
    return position; 
}


int[] array = new int[10];  //*1* - в массиве array 10элементов  
                            //(new int[10] -означает создание нового массива с 10 элементами)
                            // по умолчанию он наполнен  нулями 0
FILLArray(array);      //*2*-  метод который нам заполнил масив

//array[4]=4;// !!!!принудительно ставим 4 в  4 позицию  чтобы кроме рандомныхбыла и эта  4 четверка
                    //  для проверки корректности поиска до первого совпадения (чтобы не выводила дубли) 

PrintArray(array);     //*3*-  метод который нам распечатал массив 
Console.WriteLine();

int pos = IndexOf(array,4);//*4*- в програме IndexOf найти позицию индекса  с числом "4"
Console.Write("искомое = ");
Console.WriteLine(pos);