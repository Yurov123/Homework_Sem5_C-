// Написать программу для замены элементов массива на противоположные.


int [] Input ()
{
    Console.WriteLine("Enter the dimension of the array:"); // введите размерность массива
    int n = int.Parse(Console.ReadLine());
    int [] a = new int[n];
    for (int i = 0; i < n; ++i) 
      {
        Console.Write("a[{0}]= ", i);
        a[i] = int.Parse(Console.ReadLine());
      }
      return a;
    }
void Print(int[] a) 
    {
      for (int i = 0; i < a.Length; ++i) Console.Write("{0} ", a[i]);
      Console.WriteLine();
    }
 
void Change(int[] a)
    {
      for (int i = 0; i < a.Length; ++i)
      if (a[i] > 0) a[i] = -a[i];
    }
 
    int[] myArray = Input();
    Console.WriteLine("Source array:"); // Исходный массив
    Print(myArray);
    Change(myArray);
    Console.WriteLine("Modified Array:"); // Измененный массив
    Print(myArray);
    




