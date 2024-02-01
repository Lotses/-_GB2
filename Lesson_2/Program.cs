
// Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
Console.Clear();
System.Console.Write("Введите целое число: ");
int user_number = int.Parse(System.Console.ReadLine()!); 
Console.WriteLine(user_number % (7 * 23) == 0 ? "Число кратно и 7 и 23" : "Число не кратно 7 и 23");

// Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

int x = 0;
int y = 0;

while (x == 0){
    System.Console.Write("Введите значение Х не равное 0 : ");
    x = int.Parse(System.Console.ReadLine()!);
}

while (y == 0){
    System.Console.Write("Введите значение Y не равное 0 : ");
    y = int.Parse(System.Console.ReadLine()!);
}

if (x > 0 && y > 0)
    Console.WriteLine("Точка лежит в I четверти");
else if (x > 0 && y < 0)
    Console.WriteLine("Точка лежит в IV четверти");
else if (x < 0 && y > 0)
    Console.WriteLine("Точка лежит в II четверти");
else if (x < 0 && y < 0)
    Console.WriteLine("Точка лежит в III четверти");

// Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int number = 0;
while (number < 10 || number > 99){
    System.Console.Write("Введите целое число из отрезка [10, 99] : ");
    number = int.Parse(System.Console.ReadLine()!);
}

if (number / 10 > number % 10)
    System.Console.WriteLine($"Самая большая цифра : {number / 10}");
else 
    System.Console.WriteLine($"Самая большая цифра : {number % 10}");

// Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.

int number_2 = 0;
while (number_2 <= 0){
    System.Console.Write("Введите натуральное число : ");
    number_2 = int.Parse(System.Console.ReadLine()!);
}
string str_number = number_2.ToString();

foreach(char a in str_number)
{
    Console.Write($"{a}, ");
}