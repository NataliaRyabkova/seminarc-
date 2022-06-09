
/* 
int FindMaxPart(int num)
{
    int dec, ed;

    if (num >= 10 && num <=99)
    {
        dec = num / 10;
        ed = num % 10;
    
       if (dec > ed)
       {
        return dec;
       }
       else
       {
        return ed;
       }
    }
    else
    {
        return -1;
    }
}

Console.Write (" Input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindMaxPart(a);
if (result == -1)
{
    Console.WriteLine(" Yor number is not a two-digit!");

}

Console.WriteLine($"Bigger  number of {a} is {result}");
*/

/*
int Cutnumber()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($" Current number is {num}");
    int sot = num/ 100;
    int ed = num % 10;
    int result = sot * 10 + ed;
    return result;
}
Console.WriteLine(Cutnumber());
*/


/*
string IsAligiot(int num1, int num2)
{
    if(num2 % num1 == 0) 
    {
        return "True";
    }
    else 
    {
       return "False, rest num is + (num2 % num1)";
    }
}

Console.Write ("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

string result = IsAligiot(num1,num2);
if (result == "True")
{
    Console.Write ("Второе число кратно первому ");
}
else
{
 Console.Write ("Второе число НЕ кратно первому " + (num2 % num1) );
}
*/

 
bool Kratnost(int num)
{
    if(num % 23 ==0 && num % 7 ==0)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Console.Write ("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (Kratnost(num) ==  true) 
{
    Console.Write ("Число кратно 7  и 23 ");
}
else
{
    Console.Write ("Число НЕ кратно 7  и 23 ");
}











