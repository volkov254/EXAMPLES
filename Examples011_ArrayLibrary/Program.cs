void FillArray(int[] collection) // наименование метода
{
     int length = collection.Length; //  определили длинну массива 
     int index = 0; // позиция индекса ,.. по умолчанию она начинается с 0
     while(index < length)// цикл (пока)
     {
        collection[index] = new Random().Next(1 , 10); // к аргументу Collection положить новое случайное число из диапозона 1 - 10
        index++;// index = inde + 1;
     }

}

void PrintArray(int[] col); // печатает массив
{
    int count = col.Length; // количество элементов равное длинне массива
    int position = 0; // наименование позици
    while(position < count)// цикл (пока "position" меньше , чем "count" делай  выводи на экран консоль  значение текущего элемента)
    {
        Console.WriteLine(col[position]); //выводи на экран консоль  значение текущего элемента
    }
    
}

int[] array  = new int [10]; //// Создай новый массив, в котором будет 10 элементов...

