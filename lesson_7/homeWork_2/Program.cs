/* Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет. */

int Prompt(string message){
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num; 
}

int n = Prompt("Введите n");
int m = Prompt("Введите m");
int value = Prompt("Введите число");

int[,] array = new int[n,m];

FillArray(array);
PrintArray(array);
checkValue(array, value);


void FillArray(int[,] arr){
    for (int i = 0; i<n; i++){
        for(int j = 0; j<m; j++){
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] arr){
    for (int i = 0; i<n; i++){
        for(int j = 0; j<m; j++){
            System.Console.Write(" " + array[i,j]); 
        }
    System.Console.WriteLine();
    }
}

void checkValue(int[,] arr, int val){
    bool check = true;
    for (int i = 0; i<n; i++){
        for(int j = 0; j<m; j++){
            if(arr[i,j] == val){
                check = false;
                break;
            }
        }
        if(check == false) break;
    }
    if(check) System.Console.WriteLine("Такого числа нет в массиве");
        else System.Console.WriteLine(val);
}


