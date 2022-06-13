
/*

void Palindrom(int num)
{
    if(num < 0) num = num*(-1);
    {
        if(num >=10000 && num <= 99999)
        {

            if(num / 10000 == num % 10 &&  num / 1000 % 10 == num / 10 % 10)
            Console.WriteLine( "Введенное число палиндром");
            else 
            Console.WriteLine("Введенное число НЕ палиндром");
        }

        else 
        {
        Console.WriteLine( "Введенное число НЕ пятизначное");
        }
    }
}

Console.WriteLine("Введите пятизначное число");
int a = Convert.ToInt32(Console.ReadLine());
Palindrom(a);
*/


/*

double Rasstoyanie(double xA, double yA, double zA, double xB, double yB,double zB )
{
    return Math.Sqrt((xB-xA)*(xB-xA) + (yB-yA)*(yB-yA) + (zB-zA)*(zB-zA));    
}


Console.WriteLine("Введите координаты первой точки xA");
double num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки yA");
double num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты первой точки zA");
double num3 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки xB");
double num4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки yB");
double num5 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки zB");
double num6 = Convert.ToInt32(Console.ReadLine());

double result = Rasstoyanie (num1,num2,num3,num4,num5,num6);

if(result>0)
Console.WriteLine("Расстояние между точками равно " + result);
else
Console.WriteLine("Расстояние между точками = 0");
*/


void Kub(int x)
{
    if (x < 0) x = x * (-1);
    int num = 1;
    while(num <= x)
        {
        Console.Write((num*num*num) + " ");
        num ++;
        }
   if (x==0)
   Console.WriteLine("Нуль в кубе равен 0");

}

Console.WriteLine ("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
Kub (num1);

