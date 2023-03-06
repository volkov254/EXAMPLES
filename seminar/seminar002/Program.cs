/// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*Console.Clear();
Console.WriteLine();
Console.Write("Введи трёхзначное число: ");
int threenumber = Convert.ToInt32(Console.ReadLine());
string stringnumber = Convert.ToString(threenumber);
Console.WriteLine( $"{threenumber} -> {stringnumber[1]}");*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*Console.Write("Введите число: ");
int Anynumber = Convert.ToInt32(Console.ReadLine());
string AnynumberText = Convert.ToString(Anynumber);
if (AnynumberText.Length > 2)
{
Console.WriteLine($"{Anynumber} -> {AnynumberText[2]}");
}
else {
  Console.WriteLine("-> третьей цифры нет");
}*/

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());
void CheckingTheDayOfTheWeek (int dayNumber) 
{
  if (dayNumber == 6 || dayNumber == 7) 
  {
  Console.WriteLine("(этот день выходной) -> да");
  }
  else if (dayNumber < 1 || dayNumber > 7) 
 {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет");
}
CheckingTheDayOfTheWeek(dayNumber);*/