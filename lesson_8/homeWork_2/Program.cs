/* Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц. */

//int row = Prompt("Введите строку");
//int col = Prompt("Введите столбец");

int[,] a  = 
            {{2, 4},
             {3, 2}};

int[,] b = {
            {3,4},
            {3,3}};

int[,] c = new int[2,2];
c = MultMatrix(a, b);
//FillArray(array);
PrintArray(a);
System.Console.WriteLine();
PrintArray(b);
PrintArray(c);

int[,] MultMatrix(int[,] m1, int[,] m2){
    int[,] r = new int[2,2];
    for (int i = 0; i < m1.GetLength(0); i++)
            {
                for (int j = 0; j < m2.GetLength(1); j++)
                {
                    for (int k = 0; k < m2.GetLength(0); k++)
                    {
                        r[i,j] += m1[i,k] * m2[k,j];
                    }
                }
            } 
    return r;
}

/* void FillArray(int[,] arr){
    for (int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            array[i,j] = new Random().Next(0, 10);
        }
    }
} */

/* int Prompt(string message){
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num; 
} */

void PrintArray(int[,] arr){
    for (int i = 0; i<arr.GetLength(0); i++){
        for(int j = 0; j<arr.GetLength(1); j++){
            System.Console.Write(" " + arr[i,j]); 
        }
    System.Console.WriteLine();
    }
}

