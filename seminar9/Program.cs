/*
void ShowNums(int n)
{
    if(n != 1) 
        ShowNums(n-1);
        Console.Write (n + " ");
}


Console.Write("Input integer positive number: ");
int num = Convert.ToInt32(Console.ReadLine());
ShowNums(num);
*/



void ShowNums(int m, int n)
{
   if(n != m)
        ShowNums(m, n - 1);
    Console.Write (n + " ");    
}

Console.Write("Input integer positive number m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer positive number n: ");
int n = Convert.ToInt32(Console.ReadLine());

ShowNums(m,n);


/*
int SummaNumber (int n)
{
    if (n /10 != 0)
        return SummaNumber (n / 10) + n % 10;
    else
        return n;
}

Console.Write("Input integer positive number n: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (SummaNumber(n));
*/
/*
int Stepen (int a, int b)
{
    if( b != 0)
    return a * Stepen (a, (b-1));
    else return 1;
}

Console.Write("Input integer positive number a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input integer positive number b: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Stepen(a,b));

*/