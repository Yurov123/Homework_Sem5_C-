// Найти сумму чисел одномерного массива, стоящих на нечётной позиции.


var rnd = new Random();
var arr = new int[9];
 
for (int i = 0; i < arr.Length; i++)
    Console.Write("{0}\t", arr[i] = rnd.Next(3,50 ));
    Console.WriteLine();
 
var odd = arr.Where((element, index) => index % 2 != 0);
           
Console.WriteLine("Odd. Quantity: {0}. Summ: {1}.", odd.Count(), odd.Sum());
Console.ReadKey();
        
    
