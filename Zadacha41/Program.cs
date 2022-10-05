void Zadacha41()
{
    Random random = new Random();
    int size=random.Next(4,11);
    Console.WriteLine ($"Размер массива {size}");
    int[] numbers= new int[size];
    FillArray(numbers);
    PrintArray(numbers);
  
    Console.WriteLine ($"Положительных элементов {Count(numbers)}");
}   

    
void FillArray(int[]num)
{
    Console.WriteLine ($"Введите {num.Length} чисел");
    for (int i=0; i<num.Length;i++)
    {        
        num[i]=Convert.ToInt32(Console.ReadLine());
    }
  
}
void PrintArray(int[]num)
{
    for (int i=0; i<num.Length; i++)
    {
        Console.Write(num[i]+" ");
        
    }
    Console.WriteLine();
}
int Count(int [] num)
{
    int count=0;
    for (int i=0; i<num.Length; i++)
    {
        if (num[i]>0)
        count+=1;
    }
return count;
}

Zadacha41();
