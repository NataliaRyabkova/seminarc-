/*
//Задача 1. 


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
    
    char [] vowelsimvol = {'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y'};
    int count = 0;
    for (int i = 0; i < array.Length; i++)  
        {
            for (int j = 0; j < vowelsimvol.Length; j++)
                if (array [i][0] == vowelsimvol[j]) 
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
            for (int i = 0; i < array.Length-1; i= i+2)
                for (int j = 0; j < array.Length/2; j= j+array.Length/2)                
                {              
                    array1 [j] = array [i] + array [i+1];
                    Console.WriteLine (array1[j]); 
                }
             
        }

        else 
        {
            
            string [] array2 = new string[(array.Length+1)/2];
            for (int i = 0; i <= array.Length-3; i= i+2)
            {

                for (int j = 0; j < (array.Length+1)/2; j= j+(array.Length+1)/2)
                {
                    array2 [j] = array [i] + array [i+1];
                    Console.WriteLine (array2[j]);     
                }
            }
        
        Console.WriteLine(array[array.Length-1]);    

        }
    
}
     
   
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);
//Console.Write (String.Join(", ", (PairwiseArray(names))));
PairwiseArray(names);

