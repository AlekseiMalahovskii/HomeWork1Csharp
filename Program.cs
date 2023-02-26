/*
Task 1: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/*
Console.Write("Input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
   Console.WriteLine("min = " + b + ", " + "max = " + a); 
}

if (a < b)
{
    Console.WriteLine("min = " + a + ", " + "max = " + b);
}

if (a == b)
{
    Console.WriteLine("Числа равны");
}
*/



/*
Task 2: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/

/*
Console.Write("Input a number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > number1) 
{
   max = number2; 
}

if (number3 > number2) 
{
   max = number3; 
}

Console.WriteLine("max = " + max);
*/


/*
Task 3: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет
*/

/*
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number%2 == 0) 
{
   Console.WriteLine("Введенное число четное"); 
}

else
{
   Console.WriteLine("Введенное число нечетное"); 
}
*/


/*
Task 4: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/

/*
Console.Write("Input N: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = 2;

while(current < num)

{
    Console.Write(current + " ");
    current+=2;
}
*/


