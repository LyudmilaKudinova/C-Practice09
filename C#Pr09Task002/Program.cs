//Задача 66: Задайте значения M и N. 
//Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int SumRec(int a, int b)
{
    if (a <= b) return SumRec(a, b - 1) + b;
    else return 0;
}
Console.WriteLine(SumRec(1, 12));