﻿int [] array = { 1, 454, 4, 54, 544545, 4711, 721, 4 }; 

int n = array.Length;
int find = 4; 

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // прервать;
    }
    // index = index + 1;
    index++;
}
