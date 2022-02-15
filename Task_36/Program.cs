//  Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечётных/чётных чисел.

var mas = new int[23];
Random r = new Random();
for (int i = 0; i < mas.Length; i++)
{
mas[i] = r.Next(100,999);
Console.Write(mas[i] + " ");
}
Console.WriteLine();
int count1 = 0;

for (int i = 0; i <  mas.Length; i++)
{
if (mas[i] % 2 != 0)
++count1;
}
Console.WriteLine();
Console.WriteLine("Number of odd elements: " + count1.ToString()); // Количество нечетных элементов

 int count2 = 0;

for (int i = 0; i <  mas.Length; i++)
{
if (mas[i] % 2 == 0)
++count2;
}
Console.WriteLine();
Console.WriteLine("Number of even elements: " + count2.ToString()); // Количество четных элементов     
      

      
