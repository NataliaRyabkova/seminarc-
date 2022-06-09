/*
int num1, num2;

Console.Write( "Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write( "Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2)
{
    Console.WriteLine("Максимальное число = " + num1);
    Console.WriteLine("Минимальное число = " + num2);
}
else
{
    Console.WriteLine("Максимальное число = " + num2);
    Console.WriteLine("Минимальное число = " + num1);
} 
*/

 
int num1, num2, num3;

Console.Write( "Введите первое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write( "Введите второе число: ");
num2 = Convert.ToInt32(Console.ReadLine());

Console.Write( "Введите третье число: ");
num3 = Convert.ToInt32(Console.ReadLine());


if(num1 > num2 && num1 > num3)
{
    Console.WriteLine("Максимальное число = " + num1);  
    if(num2 > num3)
    {
    Console.WriteLine("Максимальное число = " + num2);
    }
}
else
{
    Console.WriteLine("Максимальное число = " + num3);
}


/*
int a;

Console.Write( "Введите число: ");
a = Convert.ToInt32(Console.ReadLine());


if(a % 2 == 0)
{
Console.WriteLine("Введеное число четное ");
}
else
{
Console.WriteLine("Введеное число НЕчетное ");   
}
*/


/*int N;

Console.Write( "Введите число: ");
N = Convert.ToInt32(Console.ReadLine());

int current = 1;

while(current <= N)
{
    if(current % 2 ==0)
    {
      Console.Write(current + " ");   
    } 
current ++;
}
*/
