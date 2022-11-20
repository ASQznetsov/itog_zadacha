using System;
using static System.Console;
Clear();
string[] str1;
WriteLine("Введите массив строк через пробел");
string line = ReadLine();
str1 = line.Split(' ');

string[] str2 = new string[str1.Length];
void fillstr2(string[] str1, string[] str2)
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
void fillstr2(string[] str1, string[] str2)
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
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
fillstr2(str1, str2);
WriteLine("Результат:");
PrintArray(str2);