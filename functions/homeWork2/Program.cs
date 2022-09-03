/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. */

int a = Int32.Parse(Console.ReadLine());;

void returnThirdNum(int n){
    string convertArray = n.ToString();
    int[] arrInt = new int[convertArray.Length];

    for(int i = 0; i < convertArray.Length; i++){ 
        arrInt[i] = int.Parse(convertArray[i]+ "");
        //Console.WriteLine(arrInt[i]);
    }
    if(arrInt.Length<3){
        Console.WriteLine("Нет третьего числа");    
    } else {
        Console.WriteLine(arrInt[2]);
    }
     
}

returnThirdNum(a);
//Console.WriteLine(returnThirdNum(a));


