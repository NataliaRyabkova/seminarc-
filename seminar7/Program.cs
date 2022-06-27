/*
int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];

    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}


int[,] array = CreateRandomTwoDemArray(4, 5, 1, 10);
*/


/*
int[,] CreateArrayij(int a, int b)
{
    int[,] newMatrix = new int[a,b];

    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = i + j;
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}

int[,] array = CreateArrayij(5, 5);

*/



/*

int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];

    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}




int[,] CreateArrayEvenIndexQuad(int [,] array)
{

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if ( i % 2 == 0 && j % 2 ==0)
            {
            array [i,j] *= array[i,j];
            Console.Write(array[i,j] + " ");
            }
        }
        Console.WriteLine();
    }
    return array;
}

 int[,] myArray = CreateRandomTwoDemArray(5, 5, 1, 10);

 Console.WriteLine();

 int[,] array = CreateArrayEvenIndexQuad(myArray);
*/

int[,] CreateRandomTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a,b];

    for(int i = 0; i < a; i++)
    {
        for(int j = 0; j < b; j++)
        {
            newMatrix[i,j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i,j] + " ");
        }
        Console.WriteLine();
    }
    return newMatrix;
}




int[,] SumOfDiagonal(int [,] array)
{
    int sum = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            if ( i == j)
            {
            sum += array[i,j];
           
            }
        }
        
    }
    return sum;
}

 int[,] myArray = CreateRandomTwoDemArray(5, 5, 1, 10);

 Console.WriteLine(SumOfDiagonal(myArray));


