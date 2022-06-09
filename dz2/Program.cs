/*
int SecondDigit(int num)
{
    int dec;

    if (num >= 100 && num <=999)
    {
        dec = num / 10 % 10;
        return dec;
       
    }
    else
    {
        return -1;
    }
}

Console.Write (" Введите трехзначное число ");
int a = Convert.ToInt32(Console.ReadLine());


int result =  SecondDigit(a);
if (result == -1)
{
    Console.WriteLine(" Число не трехзначное");

}
else 
{
   Console.WriteLine(result); 
}
*/








string ThirdDigit(int num)
{
    
    if( num >= 100)

    {

        string x = Convert.ToString(num);
        return  "Третья цифра =  x[2]";
    }
   
     else 
     {
        return "нет";

     }  
}



Console.Write ("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

string result = ThirdDigit(a);

if (result == "нет")
{
    Console.WriteLine("Третьей цифры нет");
}
else
{    
    string x = Convert.ToString(a);
    Console.Write (" Третья цифра =" + x[2]);
}






/*
bool Weekend (int n)
{
    
    if (n == 6 ^ n == 7)
    {
    return true;
    }
    else
    {
    return false;
    }
}
    
    

Console.Write (" Введите цифру, обозначающую день недели: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a >=1 && a<=7)
{
   if (Weekend(a) == true) 
   {
    Console.Write ("Ура, выходной");
   }
    else
   {
    Console.Write ("Это рабочий день");
   }
 
}
else
{
    Console.Write ("Это не день недели");
}
*/






