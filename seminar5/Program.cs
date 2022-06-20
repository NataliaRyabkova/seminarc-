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

int  FindPositiveSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i];
    }
    return sum;
}

int  FindNegativeSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] < 0) sum += array[i];
    }
    return sum;
}


int[] myArray = CreateRandomArray(12, -9, 9);

Console.WriteLine("Сумма положительных элементов " + FindPositiveSum(myArray));
Console.WriteLine("Сумма отрицательных элементов " + FindNegativeSum(myArray));

*/

int[]  CateRandomArray(int size, int min, int max)
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

/*
void ReservedArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i]= array[i] * (-1);
        Console.Write(array[i]+ " ");
    }
   
}

*/

/*

int FindCountElementRange (int [] array, int min, int max)
{
    int sum = 0;
    for (int i =0; i < array.Length; i++)
    {
        if (array[i] >= min && array [i] <= max) sum++;
    }
    return sum;
}
*/



bool FindNumberinArray(int[] array, int a)
{  
for(int i = 0; i < array.Length; i++)

    {
        if(array[i] == a) return true;        
    }

return false;
   
}



Console.WriteLine("Введите количество элементов в массиве ");
int size1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Минимальный элемент массива ");
int min1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Максимальный элемент массива ");
int max1 = Convert.ToInt32(Console.ReadLine());


int[] myArray = CateRandomArray(size1,min1, max1);

/*
Console.Write("Замененный массив:   ");
ReservedArray(myArray);
*/

Console.WriteLine();


int find = 5;
Console.WriteLine ("В массиве число " + find  +  ((FindNumberinArray (myArray, find))));


/*
int minnum = 10;
int maxnum = 99;

Console.WriteLine ("Количество цифр в отрезке от " + minnum + " до " + maxnum + " = " + FindCountElementRange(myArray, minnum, maxnum));
*/