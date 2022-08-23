/*
// Задача 2.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write( "input first number: " );
int n1 = Convert.ToInt32(Console.ReadLine());
 Console.Write( "input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

int max = n1; 
if (n1 > max ) max = n1; 
if (n2 > max ) max = n2; 
Console.Write("max = ");
Console.WriteLine(max);

*/
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write( "input first number: " );
int n1 = Convert.ToInt32(Console.ReadLine());
 Console.Write( "input second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
 Console.Write( "input third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

int max = n1; 
if (n1 > max ) max = n1; 
if (n2 > max ) max = n2; 
if (n3 > max ) max = n3;
Console.Write("max = ");
Console.WriteLine(max);

