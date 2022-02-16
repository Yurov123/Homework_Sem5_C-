//  В указанном массиве вещественных чисел найти разницу между максимальным и минимальным элементами.
Console.Clear();
double[] d = new double[10];
void FillArray(double[] array)
{
    for (int i  = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,500) + new Random().NextDouble();

    }
}
void PrintArray(double[]array)
 {
     for (int i = 0;i  < array.Length;i ++)
     {
         Console.Write($"{array[i]:0.00}  ");
   
     }
 } 
FillArray(d);
PrintArray(d);
double FindMax(double[]array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if( max < array[i]) max = array[i];
          
    }
    return max;
}
double FindMin(double[]array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if( min > array[i]) min = array[i];
          
    }
    return min;
}
Console.WriteLine($"\nMin element ={FindMin(d):0.00}  Max element ={FindMax(d):0.00}  difference ={FindMax(d) - FindMin(d):0.00} ");













