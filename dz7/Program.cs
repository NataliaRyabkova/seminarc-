
//Задача 1.
/*
double[,] CreateRandomTwoDemDoubleArray(int m, int n)
{
    double[,] newarray = new double[m,n];

    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
        {
            newarray[i,j] = new Random().NextDouble()*20-10;
            newarray[i,j] = Math.Round(newarray[i,j],1);
        }
      
    return newarray;
}

void ShowTwoDiArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
          Console.Write(array[i,j] + " ");  
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк в массиве, m");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве, n");
int n1 = Convert.ToInt32(Console.ReadLine());

double[,] myArray = CreateRandomTwoDemDoubleArray(m1, n1);
ShowTwoDiArray(myArray);
*/

//Задача 2.

int[,] CreateRandomTwoDemArray(int a, int b)
{
    int[,] newMatrix = new int[a,b];

    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(0,100);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}



int PoziciiElement(int m, int n, int[,] array)
{
  
   int num = 0;  
   for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {   
            if(i == m && j == n)
            {
               num = array[i,j]; 
                                          
            }           
                 
        }
    }
  return num;      
}



Console.WriteLine("Введите количество строк в массиве, a");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве, b");
int b1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine("Введите номер строки элемента, m");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер столбца элемента, n");
int n1 = Convert.ToInt32(Console.ReadLine());

int[,] myArray = CreateRandomTwoDemArray(a1,b1);
int result = PoziciiElement(m1, n1, myArray);

if(result > 0)
Console.WriteLine("Значение элемента равно " + result);

else
Console.WriteLine("Такого числа в массиве нет");




