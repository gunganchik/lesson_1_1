using System;

Console.Write("Введите свое имя - ");
string name = Console.ReadLine();
Console.Write("Введите свою фамилию - ");
string surname = Console.ReadLine();
Console.Write("Введите свое отчество - ");
string middle_name = Console.ReadLine();
Console.WriteLine($"{surname} {name} {middle_name}");
