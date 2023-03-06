//Вид №1
/*void Method1()
{
    Console.Wriline("Автор....");
}
Method1();



//Вид №2
void Method2(string msg);
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения ");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.ConsoleWriteLine();
        i++;
    }
}
Method21 ( msg: "Текст", count: 4);
Method21(count: 4, msg: "Новый текст");*/

// Вид #3
/*int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.Wriline(year);*/

/// вид №4
/*int Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
        return result;
    }
    
}
string res = Method4(10, "asdf");
 Console.Wriline(res);*/

/* int Method4(int count, string c)
{
    string result = string.Empty;
    for(int i = 0;i < count; i++ )
    {
        result = result + text;
        i++;
        return result;
    }
    
}
string res = Method4(10, "z");
Console.Wriline(res);*/



////Таблица умножения
/*for(int i = 2; i < 10; i++)
 {
    for(int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
 }*/
/// Таблица умножения
/*for (int i = 1; i < 9 * 9; ++i)
       {
           int a = i / 9 + 1;
           int b = i % 9 + 1;
           Console.WriteLine("{0} x {1} = {2}", a, b, a * b);
       }*/

/*for(int i = 2; i < 10; i++)
 {
    for(int j = 2; j < 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
 }*/
/*string text = "-Я думаю, – сказал князь, улыбаясь, –" 
            + "что, ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля." 
            +  "Вы так красноречивы. Вы дадите мне чаю?";
/////string s = "qwerty"
///              012
 // s[3] // r          
 string Replace (string text, char oldValue, char newValue)
 {
    string result = Snring.Empty;
     int length = text.Length;
     for (int i = 2; i < length; i++)
     {
        if()
     }
    return result;
 }*/

int[] arr = { 1, 4, 5, 6, 7, 8, 9, 4, 3, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++) 
    {
        Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
   for (int i = 0; i < array. Length - 1; i++)
   {
    int minPosition = i;
    for (int j = i + 1; j <  array. Length; j++)
   {
       if(array[j] < array[minPosition]) minPosition = j;
   }
    int temporary = array[i];
    array[minPosition] = array[i];
    array[minPosition] = temporary;
   }  
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);
