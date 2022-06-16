/*
int FindSumOfDigits(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int n = 234;
int result = FindSumOfDigits(n);

Console.WriteLine($"Сумма цифр в числе {n} равна {result}");*/


/*
int Summa(int A)
{
    int x=0;
    int sum = 0;
    while (x <= A)
    {
        sum = sum + x;
         x = x + 1;
    }
    return sum;
}
Console.WriteLine ("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int result = Summa (n);
Console.WriteLine(result);
*/


/*
int Proizvedenie(int N)
{
    int x=1;
    int p = 1;
    while (x <= N)
    {
        p = p * x;
         x = x + 1;
    }
    return p;
}
Console.WriteLine ("Введите число");
int n = Convert.ToInt32(Console.ReadLine());
int result = Proizvedenie (n);
Console.WriteLine(result);
*/








void Kolichestvo (int N)
{
    int count = 0;
    while (N > 0)
    {
        
        count = count + 1;
        N = N / 10;
    }
    Console.WriteLine(count);
}
Console.WriteLine ("Введите число");
int n = Convert.ToInt32(Console.ReadLine());

Kolichestvo(n);

/*
int size = 8;
int[] array = new int[size];

for(int i = 0; i < size; i = i + 1)
{
    array[i] = new Random().Next(0,2);
}

for(int i = 0; i < size; i = i + 1)
{
    Console.Write(array[i] + " ");
}
*/








