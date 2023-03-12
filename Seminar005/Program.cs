/*Console. Clear();
int[] array = GetArray(12, -9, 9); 
Console.WriteLine(string.Join(" ", array));
int positiveSum = GetPositiveSum(array);
int negativeSum = GetNegativeSum(array);

Console.WriteLine($"Positive sum = {positiveSum}, negativ sum = {negativeSum}");
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random(). Next(minValue);
    }
     return res;
}
int GetPositiveSum(int[] arr)
{
     int positiveSum = 0;
     foreach (int el in arr)
   {
     if (el > 0) positiveSum += el;
    }
return positiveSum;
}
int GetNegativeSum(int[] arr)
{
int negativeSum = 0;
foreach (int el in arr)
    {
      negativeSum += el < 0 ? el : 0;
    }
    return negativeSum;
}*/
/////Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
Console. Clear();
int num = GetNumberFromUser("Введите целое число А:", "Ошибка ввода!");
int[] array = GetArray(num, -99, 99);
Console.WriteLine(string.Join(" ", array));
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
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

