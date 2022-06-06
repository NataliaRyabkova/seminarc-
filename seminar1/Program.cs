/* 
int num, result;

Console.Write( "input integer number: ");

num = Convert.ToInt32(Console.ReadLine());

result = num * num;

Console.WriteLine(" Result is = " + result);

*/

/* 
int num1, num2, quad;

Console.Write( "Введите первое целое число: ");
num1 = Convert.ToInt32(Console.ReadLine());

Console.Write( "Введите второе целое число: ");
num2 = Convert.ToInt32(Console.ReadLine());

quad = num2 * num2;

if(quad == num1)
{
    Console.WriteLine("True");
}
else
{
    Console.WriteLine("False");
}
*/

int num;

Console.Write( "Введите число: ");
num = Convert.ToInt32(Console.ReadLine());

int current = num * (-1);

while(current <= num) 
{
    Console.Write(current + " ");
    current++; // current = current +1
}








