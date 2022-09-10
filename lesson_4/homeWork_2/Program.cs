/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12 */

int Prompt(string message){
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num; 
}

int findSum(int num){
    int sum = 0;
    
    while(num>0){
        sum = sum + (num % 10);
        num = num / 10;
    }
    
    return sum;
}

int a = Prompt("Введите число");

System.Console.WriteLine(findSum(a));