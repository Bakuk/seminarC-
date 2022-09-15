/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

const int size = 8;
double[] numbers = new double[size];

fullArray(numbers);
printArray(numbers);
System.Console.WriteLine();
System.Console.WriteLine("min= " + minFind(numbers));
System.Console.WriteLine("max= " + maxFind(numbers));
double res = maxFind(numbers) - minFind(numbers);
System.Console.WriteLine("Разница " + res);


void fullArray(double[] array){
    
    for(int i = 0; i<array.Length; i++){
        numbers[i] = new Random().Next(0, 100);
    }
}

void printArray(double[] array){
    for(int i = 0; i<array.Length; i++){
        System.Console.Write($"{numbers[i]} ");
    }
}

double minFind(double[] array){
    double min = array[0];
    for(int i = 0; i<array.Length; i++){
        if(min>array[i])
            min = array[i];
    }
    return min;
}

double maxFind(double[] array){
    double max = array[0];
    for(int i = 0; i<array.Length; i++){
        if(max<array[i])
            max = array[i];
    }
    return max;
}

