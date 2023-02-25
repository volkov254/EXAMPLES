void FillArray(int[] collection) // наименование метода  // void - метод ничего не возвращает... return - возвращает
{
     int length = collection.Length; //  определили длинну массива 
     int index = 0; // позиция индекса ,.. по умолчанию она начинается с 0
     while(index < length)// цикл (пока) индекс меньше элементов массива делай 
     {
        collection[index] = new Random().Next(1 , 10); // к аргументу Collection положить новое случайное число из диапозона 1 - 10
        index++;// index = inde + 1;
     }

}

void PrintArray(int[] col) // печатает массив
{
    int count = col.Length; // количество элементов равное длинне массива
    int position = 0; // наименование позици
    while(position < count) // цикл (пока "position" меньше , чем "count" делай  выводи на экран консоль  значение текущего элемента)
    {
        Console.WriteLine(col[position]); //выводи на экран консоль  значение текущего элемента
        position++; // увеличиваем текущую позицию на  один шаг
    }
    
}
int IndexOf(int[] collection, int find) // IndexOf - метод работы с массивом
{
    int count = collection.Length;
    int index = 0;
    //int position = 0;   // новая переменная для того чтобы было где сохранять
     int position = -1;  // если у нас нет нужного элемента мы условно возвращаемся на шаг назад (если нужного нам элемента нет, то покажет -1)
    while(index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // опертаро прирывания 
        }
        index++;
    }
    return position;
}
int[] array  = new int[10]; //// Создай новый массив, в котором будет 10 элементов, это его длинна (количество в массиве)...

FillArray(array); // вызвали метод FillArray, который заополнил нам массив
 array[4] = 4; // указываем место 4 в позиции масссива (здесь 4 стоит на 4 месте)
 array[6] = 4; // (здесь стоит на 6 месте в массиве)

PrintArray(array); // отдельный метод PrintArray, который вывел нам массив.
Console.WriteLine();

int pos = IndexOf(array, 4); // определим переменную "pos" и в нее положим результат работы метода IndexOf по поиску 4 в массиве
Console.WriteLine(pos);