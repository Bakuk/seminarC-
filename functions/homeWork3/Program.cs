/* Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. */

int a = Int32.Parse(Console.ReadLine());

void сheckingTheDayOfTheWeek (int week){
    switch (week){
        case 1:
            Console.WriteLine("нет");
            break;
        case 2:
            Console.WriteLine("нет");
            break;
        case 3:
            Console.WriteLine("нет");
            break;
        case 4:
            Console.WriteLine("нет");
            break;
        case 5:
            Console.WriteLine("нет");
            break;
        case 6:
            Console.WriteLine("да");
            break;
        case 7:
            Console.WriteLine("да");
            break;
        default:
            Console.WriteLine("нет такого дня");
            break;
    }
} 

сheckingTheDayOfTheWeek(a);

