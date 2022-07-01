

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
            for (int n = 0; n < array.GetLength(1); n++)
                {
                    if (array[i, j] < array[i, n])
                        {
                            int temp = array[i, j];
                            array[i, j] = array[i, n];
                            array[i, n] = temp;
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
    int sum = 0; 
    for(int j = 0; j < array.GetLength(1); j++) 
    {     
       sum += array [0,j];
    }
       int min = sum;
       int imin = 0;

        for (int k = 1; k < array.GetLength(0); k++)
        {   
            sum = 0;
            for (int i = 0; i < array.GetLength(1); i++)
            {
                sum += array [k,i]; 
            }       
                if(sum < min)
                {
                    min = sum;
                    imin = k;
                }                                                    
        }     
return imin + 1; // Для наглядности пользователям, которые считают строки с 1, а не с 0.    
} 


Console.WriteLine("Введите количество строк в массиве, a");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов в массиве, b");
int b1 = Convert.ToInt32(Console.ReadLine());

int[,] myarray = GreateNotsquareTwoDimArray(a1,b1);
if (a1 == b1) Console.WriteLine ("Введено неверное количество строк и столбцов, массив должен быть прямоугольный");
else 
{
ShowArray(myarray);
Console.WriteLine ("Строка с наименьшей суммой элементов, строка " + MinimumAmountLinek(myarray));
}




//Задача 3.
/*
int[,] SpiralArray(int n)

{
int[,] newarray = new int[n, n];
int num = 1;
int i = 0;
int j = 0;

    for (num = 1; num <= newarray.GetLength(0) * newarray.GetLength(1); num ++)
    {
        newarray[i, j] = num;
  
        if (j >= i - 1  &&  j <  newarray.GetLength(1) - (i + 1))
        j++;
        else if (i < j  &&  i >= newarray.GetLength(0) - (j + 1))
        i++;
        else if (j <= i &&  j >  newarray.GetLength(1) - (i + 1))
        j--;
        else if (i > j  &&  i <= newarray.GetLength(0) - (j + 1))
        i--;         
    }
return newarray;    
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

int[,] myarray = SpiralArray(4);
ShowArray(myarray);
*/
