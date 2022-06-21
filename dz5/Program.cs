
/*
int[]  CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1); 
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;

}

int  EvenNumbers(int[] array)
{
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
       if (array[i] % 2 == 0) count = count + 1;
    }
    return count;
}

Console.WriteLine("Введите количество элементов в массиве ");
int size1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите нижнюю границу массива ");
int min1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите верхняю границу массива ");
int max1 = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(size1,min1, max1);

Console.WriteLine("Количество четных чисел в массиве = " + EvenNumbers(myArray));

*/




/*

int[]  CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1); 
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;

}

int  OddPositions(int[] array)
{

int sum = 0;
for (int i = 0; i < array.Length; i++)
{
    if (i % 2 == 1) sum = sum + array [i];
}
return sum;
}

Console.WriteLine("Введите количество элементов в массиве ");
int size1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите нижнюю границу массива ");
int min1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите верхняю границу массива ");
int max1 = Convert.ToInt32(Console.ReadLine());


int[] myArray = CreateRandomArray(size1,min1, max1);

Console.WriteLine("Сумма элементов, стоящих на нечетных позициях = " + OddPositions(myArray));

*/


 


double[]  CreateRandomArray(int size)
{
    double[] newArray = new double[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().NextDouble()*100; 
        newArray[i] = Math.Round(newArray[i],2);
        Console.Write(newArray[i] + "  ");
    }
    Console.WriteLine();
    return newArray;
}
    
   

double Differencemaxmin(double[] array)
{

double max = array[0];
double min = array[0];

for(int i = 0; i < array.Length; i = i+1) 
{ 
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
return max-min;
}

Console.WriteLine("Введите количество элементов в массиве ");
int size1 = Convert.ToInt32(Console.ReadLine());


double[]  myArray = CreateRandomArray(size1);
Console.WriteLine("Разница между максимальным и минимальным элементом в массиве = " + Differencemaxmin(myArray));
