/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

const int size = 8;
int[] numbers = new int[size];

fullArray(numbers);
printArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine(findSum(numbers));

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

int findSum(int[] array){
    int sum = 0;
    for(int i = 0; i<array.Length; i++){
        if(i % 2 == 0){
            sum+=array[i];
        }
    }
    return sum;
}

