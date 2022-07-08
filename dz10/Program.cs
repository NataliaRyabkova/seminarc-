
//Задача 1. 

/*
string[] CreateStringArray(int size)
{
    string[] words = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} слово: ");
        words[i] = Console.ReadLine();
    }

    return words;
}

int VowelLetters (string [] array)
{  
    char [] vowelsimvol = {'a', 'e', 'o', 'u', 'y', 'i','э', 'у', 'е', 'а', 'о', 'и', 'ы', 'ё', 'ю', 'я'};
    int count = 0;
    for (int i = 0; i < array.Length; i++)  
        {
            for (int j = 0; j < vowelsimvol.Length; j++)
                if (char.ToLower(array [i][0]) == vowelsimvol[j]) 
                    count++;
        }
    return count;
}

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);
Console.Write (VowelLetters(names));
*/


//Задача 2.

string[] CreateStringArray(int size)
{
    string[] words = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} слово: ");
        words[i] = Console.ReadLine();
    }
    return words;
}


void PairwiseArray (string [] array )
{  
    string [] array1 = new string[array.Length/2];

    if (array.Length %2 == 0)
        {
            for (int i = 0; i <= array.Length-2; i= i+2)
            {              
                array1 [i - i/2] = array [i] + array [i+1];
                Console.WriteLine (array1[i - i/2]);          
            }
        }

        else 
        {            
            string [] array2 = new string[(array.Length+1)/2];
            for (int i = 0; i <= array.Length-3; i= i+2)
            {              
                array2 [i - i/2] = array [i] + array [i+1];
                Console.WriteLine (array2[i - i/2]);                    
            }        
        Console.WriteLine(array[array.Length-1]);    
        }  
}   
   
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);
PairwiseArray(names);

