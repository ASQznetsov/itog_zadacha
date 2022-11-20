using System;
using static System.Console;
Clear();
string[] str1;
WriteLine("Введите массив строк через пробел");
string line = ReadLine();
str1 = line.Split(' ');

string[] str2 = new string[str1.Length];
