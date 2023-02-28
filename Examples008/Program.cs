// нахождения максимума из 9 чисел
int Max(int arg1, int arg2, int arg3)
 {
    int result = arg1;
    if (arg2 > result) result = arg2; // если аргумент 2 больше результата (равному аргументу 1, то выводи результат) значит аргумент 2 максимальное число
    if (arg3 > result) result = arg3; // если аргумент 3 больше результата (равному аргументу 1, то выводи результат) значит аргумент 2 максимальное число
    return result;
}
int a1 = 15; // ввод данных
int b1 = 21;
int c1 = 36;
int a2 = 12;
int b2 = 23;
int c2 = 39;
int a3 = 13;
int b3 = 23;
int c3 = 331;

//int max1 = Max(a1, b1, c1);
//int max2 = Max(a2, b2, c2);
//int max3 = Max(a3, b3, c3);
//int max =  Max(max1, max2, max3);
/// здесь тоже самое что и внизу (не оптимизировано)

int max =  Max(Max(a1, b1, c1), 
        Max(a2, b2, c2), 
        Max (a3, b3, c3));
        
Console.WriteLine(max); // выводим максимальное значение