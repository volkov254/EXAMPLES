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
int num = GetNum("ввведите число", "Ошибка");
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
}