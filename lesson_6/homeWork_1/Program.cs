int n = Prompt("Введите маскимальное число");
int[] array = new int[n];
fullArray(array);
printArray(array);

int Prompt(string message){
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num; 
}

void fullArray(int[] array){
    
    for(int i = 0; i<array.Length; i++){
        System.Console.Write("Введите число ");
        array[i] = Int32.Parse(Console.ReadLine());
    }
}

void printArray(int[] array){
    int count = 0;
    for(int i = 0; i<array.Length; i++){
        if(array[i]>0) 
            count++;
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine("Из них больше нуля " + count);
}


