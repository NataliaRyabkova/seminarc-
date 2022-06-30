
int [,] GreateTwoDimArray(int m, int n, int min, int max)
{
    int[,] array = new int [m,n];
    for(int i = 0; i < m; i++)
        for(int j = 0; j < n; j++)
        array[i,j] = new Random().Next(min, max + 1);

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

/*
int [,] ChangeLines(int[,] array, int strIndex1, int strIndex2)
{
   int temp;

   for(int j = 0; j < array.GetLength(1); j++)
   {
    temp = array[strIndex1,j];
    array[strIndex1,j] = array[strIndex2,j];
    array[strIndex2,j] = temp;
   }
return array;
}

int[,] myArray = GreateTwoDimArray(4,5,1,9);
ShowArray(myArray);
myArray = ChangeLines(myArray, 0, myArray.GetLength(0) - 1);
Console.WriteLine();
ShowArray(myArray);
*/




//Задача. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

/*
int [,] Transpools(int [,] array)
{
    int temp;
    if (array.GetLength(0) == array.GetLength(1))    
    {
        for (int i = 0; i < array.GetLength(0); i ++)
        {
            for (int j = i +1; j < array.GetLength(1); j++)
            {
                temp = array[i,j];
                array[i,j] = array [j,i];
                array[j,i] = temp;
            }
        }
    }   
    else
    Console.WriteLine ("Невозможно заменить строки на столбцы");
return array;
}

int[,] myArray = GreateTwoDimArray(5,5,1,9);
ShowArray(myArray);
Console.WriteLine();
ShowArray(Transpools(myArray));
*/

//Задача 2.

int[,] DelitStroka(int[,] array)
{
    
    int imin = 0;
    int jmin = 0;
    int min = array[imin,jmin]; 

     for (int i = 0; i < array.GetLength(0); i ++)
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(array[i,j] < min) min = array[i,j]; 
                imin = i;  
                jmin = j;  
            }          
            
           for (int i = 0; i < array.GetLength(0); i ++)
           array[i,jmin] = 0;
           for (int j = 0; j < array.GetLength(1); j++)
           array [imin,j] = 0;
return array;
}

int[,] myArray = GreateTwoDimArray(5,5,1,9);
ShowArray(myArray);
Console.WriteLine();
ShowArray(DelitStroka(myArray));

