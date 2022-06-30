
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

/*
int[,] CreateRandomTwoDemArray(int a, int b)
{
    int[,] newarray = new int[a,b];
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newarray[i,j] = new Random().Next(0,100);
            Console.Write(newarray[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newarray;
}



void PositionElement(int m, int n, int[,] array)
{
    int num = 0; 
    if (m >=0 && m < array.GetLength(0) && n>=0 && n < array.GetLength(1)) 
    {
        num = array[m,n];
        Console.WriteLine("Значение элемента равно " + num); 
    }        
        else Console.WriteLine("Такого числа в массиве нет");                                                       
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
PositionElement(m1, n1, myArray);
*/






//Задача 3.


int[,] CreateRandomTwoDemArray(int a, int b)
{
    int[,] newarray = new int[a,b];
    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newarray[i,j] = new Random().Next(0,10);
            Console.Write(newarray[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newarray;
}



void AverageValue(int[,] array)
{
  
   Console.Write("Среднее арифметическое значение каждого столбца равно:  ");
   for(int j = 0; j < array.GetLength(1); j++)   
    {
        double sum = 0;
        double Sr = 0;
        for(int i = 0; i < array.GetLength(0); i++)
            {               
              sum += array[i,j];                                                                               
            }
        Sr = sum / array.GetLength(0); 
        Console.Write(Math.Round(Sr,2) + "  ");    
    }     
}

Console.WriteLine("Введите количество строк в массиве, m");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве, n");
int n1 = Convert.ToInt32(Console.ReadLine());

int [,] myArray = CreateRandomTwoDemArray(m1, n1);
AverageValue(myArray);


