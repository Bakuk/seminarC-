/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4. */

int Prompt(string message){
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num; 
}

int n = Prompt("Введите n");
int m = Prompt("Введите m");

int[,] array = new int[n,m];

FillArray(array);
PrintArray(array);


void FillArray(int[,] arr){
    for (int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr){
    for (int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            System.Console.Write(" " + array[i,j]); 
        }
    System.Console.WriteLine();
    }
}
