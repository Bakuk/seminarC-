/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */

int m = 1;
int n = 15;
System.Console.WriteLine(SumRec(m,n));

int SumRec(int m, int n){
    if(m == n)
        return m;
    return SumRec(m+1, n) + m;
}