//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 

int prompt(string message){
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num; 
}

void showCubNum(int n){
    for(int i = 1; i<=n; i++){
        System.Console.WriteLine(i * i * i);
    }
}

int num = prompt("Введите число");
showCubNum(num);
