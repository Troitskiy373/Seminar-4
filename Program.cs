/*int FindNumber(int num)
{
    int count = 0;
    while(num != 0)
   {
      num = num/10;
      count++;
   }
   
    return count;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Количество цифр равно " + FindNumber(num));*/


/*int FindFactorial(int num)
{
    int factorial = 1;
    for(int current=1;current <= num;current++)
   {
      factorial *=current;
      
   }
   
    return factorial;
}
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Факториал {num} из " + FindFactorial(num));*/


/*int CostumPow(int a, int b)
{
    int result=1;
    for(int current=1;current <= b;current++)result*=a;
       
   
      return result;
}
Console.WriteLine("Imput number: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Imput number: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($" {a} in {b} pow is " + CostumPow(a,b));*/

/*int[] CreateBinaryArray(int size)
{
   int[] array = new int[size];

   for(int i = 0; i < size;i++ )

    array[i] = new Random().Next(0,2);


   return array;
}


void ShowArray(int [] array)

{
    for(int i = 0; i< array.Length; i++)
       Console.Write(array[i] + "   ");

    Console.WriteLine();
}

Console.Write("Imput number of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[]myArray = CreateBinaryArray(size);
ShowArray(myArray);*/


