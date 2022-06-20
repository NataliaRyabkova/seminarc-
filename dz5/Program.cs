

/*

int size = 10;
int[] array = new int[size];  
Console.Write("Заданный массив: ");

for(int i = 0; i < size; i = i + 1)
    {
        array[i] = new Random().Next(100,1000);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(); 

int count = 0;
for (int j = 0; j < array.Length; j++)
{
    if (array[j] % 2 == 0) count = count + 1;
}
Console.WriteLine($"Количество четных чисел в массиве: {count}");

*/


/*
int size = 10;
int[] array = new int[size];  
Console.Write("Заданный массив: ");

for(int i = 0; i < size; i = i + 1)
    {
        array[i] = new Random().Next(-100,100);
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(); 

int sum = 0;
for (int j = 0; j < array.Length; j++)
{
    if (j % 2 == 1) sum = sum + array [j] ;
}
Console.WriteLine($"Сумма элементов стоящих на нечетных позициях: {sum}");

*/


int size = 10;
int[] array = new int[size];  
Console.Write("Заданный массив: ");
int max = array[0];
int min = array[0];

for(int i = 0; i < size; i = i + 1)
    {
        array[i] = new Random().NextDouble();
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(); 

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i];
}
Console.WriteLine();
Console.Write("Разница между максимальным и минимальным элементом равна:");
Console.Write(max - min);
    