/* Задача 1: Задайте двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. */


int row = Prompt("Введите строку");
int col = Prompt("Введите столбец");

int[,] array = new int[col,row];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
SumMin(array);


void FillArray(int[,] arr){
    for (int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

int Prompt(string message){
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num; 
}

void PrintArray(int[,] arr){
    for (int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            System.Console.Write(" " + array[i,j]); 
        }
    System.Console.WriteLine();
    }
}

void SumMin(int[,] arr){
    int sum;
    int[] arrSum = new int[arr.GetLength(0)-1];
    for (int i=0; i<arr.GetLength(1);i++) {
        sum = 0; 
        for (int j=0; j<arr.GetLength(0);j++) {
            sum+=arr[j,i];
        }
        Console.Write(" " + sum);
        arrSum[i] = sum;
    } 
    int sumItem = arrSum[0];
    int indexSum = 0;
    for(int i = 0; i<arrSum.GetLength(0); i++){
        if(sumItem<arrSum[i]){
            sumItem = arrSum[i];
            indexSum = i;           
        }
    }
    System.Console.WriteLine();
    System.Console.WriteLine(sumItem + " индекс " + indexSum);
}