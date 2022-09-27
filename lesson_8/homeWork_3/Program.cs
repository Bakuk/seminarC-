/* Задача 3. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив. */

int row = Prompt("Введите строку");
int col = Prompt("Введите столбец");

int[,] array = new int[col,row];

FillArray(array);
PrintArray(array);
System.Console.WriteLine();
bool check = Contains(array, 24);
if(check){
    System.Console.WriteLine("Присутствует");
} else{
    System.Console.WriteLine("Не присутствует");
}


void FillArray(int[,] arr){
    for (int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            array[i,j] = new Random().Next(10, 99);
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

bool Contains(int[,] arr, int value){
    bool check = false;
    for (int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            if(arr[i,j] == value){
                check = true;
                break;
            }
        }
        if(check){
            break;
        } 
    }
    return check;
}