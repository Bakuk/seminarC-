/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел. */

int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
int c = Int32.Parse(Console.ReadLine());

if(a>b && a>c){
    Console.WriteLine("max= " + a);
} else if(b>a && b>c ){
    Console.WriteLine("max= " + b);
} else if (c>a && c>b){
    Console.WriteLine("max= " + c);
}
