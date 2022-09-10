/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33] */

const int size = 8;
int[] numbers = new int[size];

fullArray(numbers);
printArray(numbers);


void fullArray(int[] array){
    
    for(int i = 0; i<array.Length; i++){
        numbers[i] = new Random().Next(0, 10);
    }
}

void printArray(int[] array){
    for(int i = 0; i<array.Length; i++){
        System.Console.Write($"{numbers[i]} ");
    }
}


