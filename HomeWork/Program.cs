//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

/*int SumNumbers(int number)
{
 int sum=0;
 while(number>0)
 {
  sum+=number%10;
  number/=10;
 }
  return sum;
}
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Сумма цифр равно " + SumNumbers(number));*/


//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int[] CreateArray(int size)
{
   int[] array = new int[size];

   for(int i = 0; i < size;i++ )

    array[i] = new Random().Next(0,100);


   return array;
}


void ShowArray(int [] array)

{
    for(int i = 0; i< array.Length; i++)
       Console.Write(array[i] + "  ");

    Console.WriteLine();
}

Console.Write("Imput number of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[]myArray = CreateArray(size);
ShowArray(myArray);

