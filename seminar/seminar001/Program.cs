/// Программа которая на вход принимает число и выдает его квдарат
/// например 4 ->16, -3 -> 9, -7 -> 49
/*Console.Write("Введите целое число "); // послание пользователю
string? userImputStr = Console.ReadLine() ?? "";  // считывание послания, возвращает строкоевое значение// сохраняя в пременной string
int userNumber = int.Parse(userImputStr); // метод Parse  работает коректно только если числовое значение

int result = userNumber * userNumber; // Формула вычисления 

Console.WriteLine($"{userNumber} -> {result}"); /// вывод результата $ - механизм интерполяции строк
Console.WriteLine(userNumber + " -> " + result); //- это метод конкатенация строк, то же самое, что и на строчке выше*///

///На вход примает два числа и проверяет не является ли это квадратом первого
/*Console.Write("Введите целое число- ");
int NumberA = Convert.ToInt32(Console.ReadLine() ?? "");
Console.Write("Введите второе число- ");
int NumberВ = Convert.ToInt32(Console.ReadLine() ?? "");

if (NumberA == NumberВ * NumberВ)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}
*/

/*Console.Write("Введите целое число ");
int week = Convert.ToInt32(Console.ReadLine());
if ((week > 7) || (week < 1)) 
{
    Console.WriteLine("Невверное число");
}

else
{
    if (week == 1) { Console.WriteLine($"{week} -> Понедельник");}
    if (week == 2) { Console.WriteLine("Вторник");}
    if (week == 3) { Console.WriteLine("Среда"); }
    if (week == 4) { Console.WriteLine("Четверг");}
    if (week == 5) { Console.WriteLine("Пятница");}
    if (week == 6) { Console.WriteLine("Суббота");}
    if (week == 7) { Console.WriteLine("Воскресение");}
}*/

////Решение задачи №2////
/*Console.Write("Введите первое число :");
string A = Console.ReadLine()??"";
int NumA = 0;
if (A !=null)
    NumA = int.Parse(A);
Console.Write("Введите второе число :");
   string B = Console.ReadLine()??"";
int NumB = 0;
if (B !=null)
    NumB = int.Parse(B);

if (NumA > NumB)
{
    Console.WriteLine($"a={NumA};b={NumB} -> max={NumA}");
}

else
{
    Console.WriteLine($"a={NumA};b={NumB} -> max={NumB}");
}
*/
// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
 /*Console.WriteLine("Введите 3 числа:");
            int NumA = Convert.ToInt32(Console.ReadLine());
            int NumB = Convert.ToInt32(Console.ReadLine());
            int NumC = Convert.ToInt32(Console.ReadLine());

            int max = NumA;
             Console.WriteLine($"{NumA};{NumB};{NumC} -> max={NumA}");
            if (NumB > max)
            {
                max = NumB;
            }
            else
            {
                Console.WriteLine($"{NumA};{NumB};{NumC} -> max={NumB}");
            }
            if (NumC > max)
            {
                max = NumC;
            }
            else
            {
                Console.WriteLine($"{NumA};{NumB};{NumC} -> max={NumC}");
            }
            */
            // // Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
            /* Console.WriteLine("Введите число:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine($"Число {num} -> Да");
            }
            else
            {
                Console.WriteLine($"Число {num} -> Нет");
            }
            */
///     Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N. 
Console.WriteLine("Введите число:");
 int Num = Convert.ToInt32(Console.ReadLine());
  int i = 1;
      bool not = true;  
      Console.WriteLine($"->");
            while (i <= Num)
            {
                if (i % 2 != 1)
                {
                    Console.Write(i + ", ");
                    not = false;
                }
                i++;
            }

            if (not)
            {
                Console.WriteLine("Нет чётных чисел!");
            }

        