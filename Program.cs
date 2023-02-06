/*Задача 19
Напишите программу, которая принимает на вход пятизначное
 число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да*/

/*Console.WriteLine("Задача №19");
Console.WriteLine("Введите пятизначное число: ");
int Number = int.Parse(Console.ReadLine());
int result = 0;
int temp = Number;
while (temp > 0)
{
    int NumberA = temp % 10;
    temp = temp / 10;
    result = result * 10 + NumberA;
}
if (Number == result)
    Console.WriteLine("число является палиндромом");
    else
    Console.WriteLine("число не является палиндромом");*/
/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек
 и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

/*Console.WriteLine("Задача №21");
Console.WriteLine("Введите координату точки A");
Console.WriteLine("Координата x");
double xA = double.Parse(Console.ReadLine());
Console.WriteLine("Координата y");
double yA = double.Parse(Console.ReadLine());
Console.WriteLine("Координата z");
double zA = double.Parse(Console.ReadLine());

Console.WriteLine("Введите координату точки B");
Console.WriteLine("Координата x");
double xB = double.Parse(Console.ReadLine());
Console.WriteLine("Координата y");
double yB = double.Parse(Console.ReadLine());
Console.WriteLine("Координата z");
double zB = double.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние между точками = {Math.Sqrt(Math.Pow((xB-xA), 2)+Math.Pow((yB-yA), 2)+Math.Pow((zB-zA), 2))}");
 
 Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт 
таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125;*/

Console.WriteLine("Задача №23");
Console.WriteLine("Введите число N");
int NumberN = int.Parse(Console.ReadLine());
double Cube = 1;
while (Cube <= NumberN)
{
    Console.Write(Math.Pow(Cube, 3) + " ");
    Cube++;
}
    
   
