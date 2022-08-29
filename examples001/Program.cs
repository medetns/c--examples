Console.WriteLine("Введите первое число");
int firstNumb = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
int secondNumb = int.Parse(Console.ReadLine());
if (firstNumb == secondNumb * secondNumb) {
    Console.WriteLine($"{firstNumb} равен квадрату {secondNumb}");
}
else if (secondNumb == firstNumb * firstNumb) {
    Console.WriteLine($"{secondNumb} равен квадрату {firstNumb}");
}
else {
    Console.WriteLine("NO");
}
