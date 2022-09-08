/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 */

int prompt(string message){
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num; 
}

int[] setCord(int x, int y, int z){
    int[] cord = new int[3];
    cord[0] = x;
    cord[1] = y;
    cord[2] = z;
    return cord;
}

void showCord(int [] cord){
    System.Console.WriteLine("x= " + cord[0]);
    System.Console.WriteLine("y= " + cord[1]);
    System.Console.WriteLine("z= " + cord[2]);
}

double findCord(int[] cord1, int[] cord2){
    return Math.Sqrt(Math.Pow(cord2[0]-cord1[0],2)+Math.Pow(cord2[1]-cord1[1],2)+Math.Pow(cord2[2]-cord1[2],2));
}

int x1 = prompt("Введите x");
int y1 = prompt("Введите y");
int z1 = prompt("Введите z");

int x2 = prompt("Введите x");
int y2 = prompt("Введите y");
int z2 = prompt("Введите z");

int[] cordinate1 = setCord(x1,y1,z1);
int[] cordinate2 = setCord(x2,y2,z2);
showCord(cordinate1);
showCord(cordinate2);

double res = findCord(cordinate1, cordinate2);
System.Console.WriteLine(res);

/* 
double findCord(){

} */

