/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее. */

int a = Int32.Parse(Console.ReadLine());
int b = Int32.Parse(Console.ReadLine());
//int max;
if(a>b){
    //max = a;
    Console.WriteLine("max= " + a);
} else{
    Console.WriteLine("max= " +  b);
}
