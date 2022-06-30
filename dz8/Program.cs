

//Задача 1.
/*
int [,] GreateTwoDimArray(int m, int n)
{
    int[,] array = new int [m,n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
        array[i,j] = new Random().Next(0,10);

return array;
}

void ShowArray(int[,] array)
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

int[,] Arrangefromminmax(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++) 
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {            
            for (int k = 0; k < array.GetLength(1) - 1; k++)
                {
                    if (array[i, k] > array[i, k + 1])
                        {
                            int temp = array[i, k + 1];
                            array[i, k + 1] = array[i, k];
                            array[i, k] = temp;
                        }
                }
        }
    } 
return array;      
}

Console.WriteLine("Введите количество строк в массиве, a");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве, b");
int b1 = Convert.ToInt32(Console.ReadLine());

int[,] myarray = GreateTwoDimArray(a1,b1);
ShowArray(myarray);
Console.WriteLine();
ShowArray(Arrangefromminmax(myarray));
*/

//Задача 2.

 int [,] GreateNotsquareTwoDimArray(int m, int n)
{
    int[,] array = new int [m,n];
        for(int i = 0; i < m; i++)
            for(int j = 0; j < n; j++)
                array[i,j] = new Random().Next(0,10);  
 return array;      
}    

void ShowArray(int[,] array)
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


int MinimumAmountLinek(int [,] array)
{   
    int min = 0;
    int sum = 0;
    int imin = 0;  
    for(int j = 0; j < array.GetLength(1); j++) 
    {     
       sum += array [1,j];
    }
       min = sum;
       imin = 1;
        for (int k = 1; k < array.GetLength(1); k++)
        {   
            for (int i = 0; i < array.GetLength(0); i++)
            {
                sum += array [i,k];      
                if(sum < min)
                {
                    min = sum;
                    imin = i;
                } 
            }                                         
        }
     
return min;     
} 


/*
int MinimumAmountLinek(int [,] array)
{
int index = 0;
    int sum = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (i == 0) result = sum;
        else if (sum < result)
        {
            result = sum;
            index = i;
        }
    }
    return index;
}
*/

Console.WriteLine("Введите количество строк в массиве, a");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве, b");
int b1 = Convert.ToInt32(Console.ReadLine());

int[,] myarray = GreateNotsquareTwoDimArray(a1,b1);
if (a1 == b1) Console.WriteLine ("Введено неверное количество строк и столбцов, массив должен быть прямоугольный");
else ShowArray(myarray);

Console.WriteLine ("Строка с наименьшей суммой элементов, строка " + MinimumAmountLinek(myarray));


