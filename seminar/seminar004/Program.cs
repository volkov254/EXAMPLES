/*/// Ввод (Input)
int num = GetNumberFromUser("Введите целое число А:", "Ошибка ввода!");
/// логика
int sumNumbers = GetSumNumbers(num);
//// Вывод (Output)
Console.WriteLine($"{num} -> {sumNumbers}");
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect && userNumber >= 0 )
           return userNumber;
        Console.WriteLine(errorMessage);   
    }
}    

int GetSumNumbers(int number)
{
    int sum = 0;
    while(number > 0 )
    {
        sum += number;
        number--;
    }
    return sum;
}*/
//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
/*int num = GetNum("ввведите число", "Ошибка");
int result = GetSumNumbers(num);
Console.WriteLine($"{num} -> {result}");
int GetNum(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect) ///&& userNumber >= 0 )
           return userNumber;
        Console.WriteLine(errorMessage);   
    }
}    

int GetSumNumbers(int number)
{
    if(number < 0 ) number *= -1;
    int count = 0;
    if(number == 0) count = 1;
    while(number > 0 )
    {
        count++;
        number/= 10;// number = number / 10;
    }
    return count;
}*/
/////Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*int num = GetNumberFromUser("Введите целое число А:", "Ошибка ввода!");
/// логика
int result = GetMultiplication(num);
//// Вывод (Output)
Console.WriteLine($"{num} -> {result}");
int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if(isCorrect && userNumber > 0 )
           return userNumber;
        Console.WriteLine(errorMessage);   
    }
}    

int GetMultiplication(int number)
{
    int sum = 1;
    while(number > 0 )
    {
        sum *= number;
        number--;
    }
    return sum;
}*/
///Задача 30: Напишите программу, которая выводит массив из 
///8 элементов, заполненный нулями и единицами в случайном порядке.
///[1,0,1,1,0,1,0,0]
int[] array = InputArray();
///PrintArray(array);
Console.WriteLine($"[{String.Join(",", array)}]");//// строчка 89 и 90 одинаковая
static int [] InputArray()
{

    int [] arr = new int [8];
    for(int i = 0; i < 8; i++)
    {
         arr[i] = new Random().Next(0,2);
    }
   return arr;
}
static void PrintArray(int [] array)
{
    int length = array. Length;
    Console.Write("[");
     for(int i = 0; i < length; i++)
     {
        Console.Write($"{array[i]},");
     }
    Console.WriteLine("]");
}

///Math.pow.