// Задача 1.



int SummNumbers(int m, int n)
{    
    if(n != m)     
        return m + SummNumbers(m + 1,n);
   else 
        return n;      
}

Console.Write("Введите нижний предел m: ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите верхний предел n: ");
int n1 = Convert.ToInt32(Console.ReadLine());

if (n1 < 0 || m1 < 0)   
Console.WriteLine ("Вы ввели отрицательное значение"); 
else
Console.WriteLine ("Сумма элементов равна " + SummNumbers(m1,n1));




//Задача 2.

/*
int NumberOfDigits(int n)
{
    if (n /10 != 0)
        return 1 + NumberOfDigits(n / 10);
    else
        return 1;
}

Console.Write("Введите число: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine (NumberOfDigits(m));
*/
