// System.Console.WriteLine("Введите первое целое число");
// int first_int = Convert.ToInt32( Console.ReadLine() );
// System.Console.WriteLine("Введите второе целое число");
// int second_int = Convert.ToInt32( Console.ReadLine() );

// if (first_int == second_int * second_int)
// {
//     System.Console.WriteLine("да");
// }
// else
//     System.Console.WriteLine("нет");


using System.Globalization;

System.Console.WriteLine("Введите целое число");
int f_int = Convert.ToInt32(Console.ReadLine());

int i = - f_int;
while (i < f_int)
{
    System.Console.Write(i + ",");
    i += 1;
}
System.Console.WriteLine(i);
