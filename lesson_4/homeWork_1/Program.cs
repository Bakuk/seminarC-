/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16 */

int Prompt(string message){
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num; 
}

int exp(int num1, int num2){
    int res = 1;
    for (int i = 1; i <= num2; i++){
        res = res * num1;
    }    
    return res;
}

int a = Prompt("Введите число A");
int b = Prompt("Введите число B");


System.Console.WriteLine(exp(a,b));
