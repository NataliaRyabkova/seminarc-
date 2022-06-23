

/*
Console.Write("Введите колличество чисел, M: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];

void VvodNumber(int M)
{   
for (int i = 0; i < M; i++)
  {
    Console.Write($"Введите число {i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
  }
}


int Colichestvopositivenumber(int[] array1)
{
  int count = 0;
  for (int i = 0; i < array1.Length; i++)
  {
    if(array1[i] > 0 ) count += 1; 
  }
  return count;
}


VvodNumber(M);

Console.WriteLine($"Введено {Colichestvopositivenumber(array)} чисел больше нуля ");
*/

int[]  CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1); 
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();
    return newArray;

}





