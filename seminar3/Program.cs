
/*
int FindQuart(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;

    return -1;
}

Console.WriteLine("Введите значение х,y");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int result = FindQuart(num1,num2);

if(result == -1) Console.WriteLine("Данная точка расположена на осях");
else Console.WriteLine ($"Точка находится в {result} четверти");
*/


/*
double FindLenght(double xA, double yA, double xB, double yB)
{
    return Math.Sqrt((xB-xA)*(xB-xA) + Math.Pow((yB-yA),2));
    
}

Console.WriteLine("Введите значение xA,yA,xB,yB");

double num1 = Convert.ToInt32(Console.ReadLine());
double num2= Convert.ToInt32(Console.ReadLine());
double num3 = Convert.ToInt32(Console.ReadLine());
double num4 = Convert.ToInt32(Console.ReadLine());
double result = FindLenght (num1,num2,num3,num4);

if(result>0)
Console.WriteLine(result);
else
Console.WriteLine("Расстояние между точками =0");
*/

/*
void  Diapazon(int x)
{   
    if(x>=1 && x<=4)
    {
        if (x==1) Console.WriteLine("Х положительное, Y положительное");
        if (x==2) Console.WriteLine("Х отрицательное, Y положительное");
        if (x==3) Console.WriteLine("Х отрицательное, Y отрицательное");
        if (x==4) Console.WriteLine("Х положительное, Y отрицательное");
    }
    else
    Console.WriteLine("Введенное значение не обозначает четверть координат");
}

Console.WriteLine("Введите значение четверти");
int a = Convert.ToInt32(Console.ReadLine());
Diapazon(a);
*/

void Quadrat(int x)
{
    if (x < 0) x = x * (-1);
    else x=x*1;
    
    int current = 1;
    while(current <=x)
        {
        Console.Write((current*current) + " ");
        current ++;
        }
   if (x==0)
   Console.WriteLine("Квадрат нуля равен 0");

}

Console.WriteLine ("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Quadrat (num);


