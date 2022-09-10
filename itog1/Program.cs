﻿//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам.
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []

Console.Clear();
string[] str1 = new string[5] {"4пе", "05", "ронgrt", "%ждш*", "_______"};
string[] str2 = new string[str1.Length];

void PrintStr1(string[] str1)
{
    for (int i = 0; i < str1.Length; i++)
    {
        Console.Write($"{str1[i]}, ");
    }
}
Console.Write($" [ ");
PrintStr1(str1);
Console.Write($" ] -> ");

void StrFill(string[] str1, string[] str2)
{
    int count = 0;
    for (int i = 0; i < str1.Length; i++)
    {
    if(str1[i].Length <= 3)
        {
        str2[count] = str1[i];
        count++;
        }
    }
}

