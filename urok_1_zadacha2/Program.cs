﻿Console.WriteLine("Введите первое число");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = int.Parse(Console.ReadLine());
int max = 0;
if (a > b) {
    Console.WriteLine($"max = {a}");
}
else {
    Console.WriteLine($"max = {b}");
}

