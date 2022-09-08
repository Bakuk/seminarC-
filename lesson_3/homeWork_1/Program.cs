/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. */

int Prompt(string message){
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num; 
}

int[] convertToArray(int number){
    string convertArray = number.ToString();
    int[] arrInt = new int[convertArray.Length];

    for (int i = 0; i<arrInt.Length; i++){
        arrInt[i] = int.Parse(convertArray[i]+ "");
       // System.Console.WriteLine(arrInt[i]);    
    }
    return arrInt;
}

bool checkPalindrom(int[] value){
    bool check = true;
    for (int i = 0; i < value.Length / 2; i++){
        if (value[i] != value[value.Length-i-1]){
            check = false;
            break;
        } 
    }

    return check;
}

int n = Prompt("Введите число");

int[] array = convertToArray(n);

if(checkPalindrom(array)){
    System.Console.WriteLine("Yes");
} else{
    System.Console.WriteLine("No");
}

