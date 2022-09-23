/* Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце. */

int[,] array = new int[,] {
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4}
};

PrintArray(array);

double sum ,avg;

AvgArr(array);

void PrintArray(int[,] arr){
    for (int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            System.Console.Write(" " + array[i,j]); 
        }
    System.Console.WriteLine();
    }
}

void AvgArr(int[,] arr){
    for (int i=0; i<arr.GetLength(1);i++) {
        sum = 0; 
        avg = 0;
        for (int j=0; j<arr.GetLength(0);j++) {
            sum+=arr[j,i];
        }
        Console.WriteLine(sum/arr.GetLength(0));
    } 
}