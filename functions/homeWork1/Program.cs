/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. */

int returnSecondNumber(int n){
    return n / 10 % 10;
}


int a = Int32.Parse(Console.ReadLine());;
int res = returnSecondNumber(a);
Console.WriteLine(res);
