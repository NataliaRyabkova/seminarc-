/*
int Stepen(int A, int B)
{
    if (A < 0) A = A*(-1);
    if (B < 0) B = B*(-1);
    if (A == 0 | B == 0) 
    return -1;
    int res = 1;
    for ( int i = 1; i <= B; i++)
    {
        res = res * A;
    }
    return res;
   
 }

 Console.WriteLine ("Введите число А");
 int a = Convert.ToInt32(Console.ReadLine());

 Console.WriteLine ("Введите число B");
 int b = Convert.ToInt32(Console.ReadLine());

 int result = Stepen (a,b);

if (result == -1)
{
    Console.WriteLine("Вы ввели нулевое значение");
}
else
{
     Console.WriteLine($"А в степени В равно {result}");
}
*/

/*
int size = 8;
int[] array = new int[size];

for(int i = 0; i < size; i = i + 1)
{
    array[i] = new Random().Next(0,100);
}


int PrintArray(int[] array)

    for(int i = 0; i < size; i = i + 1)
{
    Console.Write(array[i] + " ");
}

*/


int size = 8;
int[] array = new int[size];

    for(int i = 0; i < size; i = i + 1)
    {
         array[i] = new Random().Next(0,100);
        Console.Write(array[i] + " ");
    
    }
    Console.WriteLine(); 

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    Console.Write(array[i]+ " ");
}

PrintArray(array);


