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


void PrintArray(int[,] arr){
    for (int i = 0; i<n; i++){
        for(int j = 0; j<m; j++){
            System.Console.Write(" " + array[i,j]); 
        }
    System.Console.WriteLine();
    }
}

void FillArray(int[,] arr){
    for (int i = 0; i<n; i++){
        for(int j = 0; j<m; j++){
            array[i,j] = new Random().Next(0, 10);
        }
    }
}

