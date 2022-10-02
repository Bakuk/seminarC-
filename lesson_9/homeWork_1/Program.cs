/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */



int val = 5;

Console.WriteLine(Rec(val));
string Rec(int num){
    if(num == 1)
        return num.ToString();
    
    return num.ToString() + " " +  Rec(num-1);
}


