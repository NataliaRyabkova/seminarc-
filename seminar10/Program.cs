
//string[] names = { "ivan", " Anna", "Max", "Denis"};

string[] CreateStringArray(int size)
{
    string[] words = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} word: ");
        words[i] = Console.ReadLine();
    }

    return words;
}


/*
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.WriteLine(array[i] + " ");

    Console.WriteLine();
}

int NumberOfLongWords(string[] array)
{
    int count = 0;
    for (int i = 0;i < array.Length; i++) 
        if ( array[i].Length >= 5)
            count++;

    return count;
}

Console.Write ("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());

string [] names = CreateStringArray(size);

Console.WriteLine("Number of long words is " + NumberOfLongWords(names));
*/
/*
string[] CombainArray(string[] array1, string[] array2)
{
    int sizemax = array1.Length;
    int sizemin = array2.Length;
    string[] arraymax = array1;



    if (array2.Length > array1.Length)
    {
        sizemax = array2.Length;
        sizemin = array1.Length;
        arraymax = array2;
    }

    string[] array3 = new string[sizemax];

    for (int i = 0; i < sizemin; i++)
        array3[i] = array1[i] +  " " + array2[i];


    for (int i = sizemin; i < sizemax; i++)
        array3[i] = arraymax[i];


    return array3;

}

Console.Write("Input number of nams: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.Write("Input number of sornams: ");
int size1 = Convert.ToInt32(Console.ReadLine());

string[] names1 = CreateStringArray(size);
string[] names2 = CreateStringArray(size1);



ShowArray(CombainArray(names1,names2));
*/

int SymbolOfWords (string [] array, char a, char b)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)  
        if ( array [i][0] == a || array[i][0] == b)
        count++;

    return count; 
}

Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input First Symbol: ");
char a = Convert.ToChar(Console.ReadLine());
Console.Write("Input First Symbol: ");
char b = Convert.ToChar(Console.ReadLine());

string[] names = CreateStringArray(size);
Console.Write (SymbolOfWords(names, a, b));
