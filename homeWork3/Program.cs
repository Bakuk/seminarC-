/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка). */

int a = Int32.Parse(Console.ReadLine());

if(a % 2 == 0){
    Console.WriteLine("yes");
} else {
    Console.WriteLine("no");
}
