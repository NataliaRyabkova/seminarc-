/*
int[] ReverseArray(int[] array)
{
    int temp;
    int j = array.Length - 1, i = 0;

    while (i < j)
    {
        temp = array [i];
        array [i] = array [j];
        array [j] = temp;

        i++;
        j--;
    }
/*
    for(int i < array.Length / 2; i++;j--)
    {
        temp = array[i];
        array[i] = array [j];
        array [j] = temp;
    }
    
    return array;
}
*/
/*

int[] myArray = {2,4,6,8};
myArray = ReverseArray(myArray);

for(int i =0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}

*/

/*
bool Triangle(int A, int B, int C)
{
    if (A + B > C && A + C > B && B + C > A )
    return true;
    else return false;
}

Console.WriteLine("Введите A ");
int A1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите B ");
int B1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите C ");
int C1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Triangle(A1,B1,C1));
*/


/*
void Fibonacci (int N)
{
    int[] array = new int [N];

    array [0] = 0;
    array [1] = 1;
    Console.WriteLine(array [0]);
    Console.WriteLine(array [1]);
    for (int i = 2; i < N; i ++)
    {
        array [i] = array[i-1] + array[i-2];
        Console.WriteLine(array [i]);
    }
}



Console.WriteLine("Введите N");
int N1 = Convert.ToInt32(Console.ReadLine());


Console.WriteLine();
Fibonacci(N1);
*/


string BinaryNumber(int num)
{
    string result = string.Empty;
    while(num > 0)
    {
        result = num % 2 + result;
        num /=2;
    }
    return result;
}

Console.WriteLine(BinaryNumber(15));
