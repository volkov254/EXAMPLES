﻿// нахождение максимума из массива 9 чисел
int Max(int arg1, int arg2, int arg3)
 {
    int result = arg1;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}
//               0  1   2    3   4   5  6   7    8 // нумерация индексов
int [] array = {11, 12, 322, 41, 51, 36, 17, 81, 19};

int max = Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(max); // выводит максмимальное из 9 чисел  в массиве 

