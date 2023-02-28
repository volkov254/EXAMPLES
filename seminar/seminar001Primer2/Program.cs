/// Программа которая на вход принимает число и выдает его квдарат
/// например 4 ->16, -3 -> 9, -7 -> 49
Console.Write("Введите целое число "); // послание пользователю
int userNumber = int.Parse(Console.ReadLine() ??"");
double result = (int) Math.Pow(userNumber, 2); // = int result = userNumber * userNumber// функция квадрата числа


Console.WriteLine($"{userNumber} -> {result}"); /// вывод результата $ - механизм интерполяции строк
//Console.WriteLine(userNumber + " -> " + result); //- это метод конкатенация строк, то же самое, что и на строчке выше