/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2 */
const int size = 8;
int[] numbers = new int[size];

fullArray(numbers);
printArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine(countEven(numbers));


void fullArray(int[] array){
    
    for(int i = 0; i<array.Length; i++){
        numbers[i] = new Random().Next(100, 999);
    }
}

void printArray(int[] array){
    for(int i = 0; i<array.Length; i++){
        System.Console.Write($"{numbers[i]} ");
    }
}

int countEven(int[] array){
    int count = 0;
    for(int i = 0; i<array.Length; i++){
        if(array[i] % 2 == 0){
            count++;
        }
    }
    return count;
}