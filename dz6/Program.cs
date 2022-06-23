

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




int []  SpecifiedArray(int size)
{
    int[] newArray = new int[size];
    Console.WriteLine("Заданный массив");
    for(int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(0,100); 
        Console.Write(newArray[i]+ " ");

    }
    Console.WriteLine();
    return newArray;
}



void CopyArray(int[] array1, int[] array2)
{
    Console.WriteLine("Копия массива");
    for (int i = 0; i < array1.Length; i++)
    {
        array1[i] = array2[i]; 
        Console.Write(array1[i]+ " ");
    }
   
}
    

Console.WriteLine("Введите количество элементов в массиве ");
int size1 = Convert.ToInt32(Console.ReadLine());
CopyArray(new int[size1],SpecifiedArray(size1));




