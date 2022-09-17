//Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
string NumbersRec(int a, int b)
{
    if (a <= b) return NumbersRec(a, b - 1) + $"{b} ";
    else return String.Empty;
}
Console.WriteLine(NumbersRec(1, 12));